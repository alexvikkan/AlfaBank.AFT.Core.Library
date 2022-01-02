﻿using System;
using System.Collections.Generic;
using System.Linq;
using AlfaBank.AFT.Core.Infrastructures.Reports;
using AlfaBank.AFT.Core.Supports;
using TechTalk.SpecFlow;

namespace AlfaBank.AFT.Core.Models.Context
{
    public class ConfigContext
    {
        private readonly string[] commonTag = new[] { "common" };

        private readonly ConfigSupport configSupport;
        private readonly VariableContext variableContext;
        private readonly FeatureContext featureContext;
        private readonly ScenarioContext scenarioContext;

        public ConfigContext(ConfigSupport configSupport, VariableContext variableContext,
            FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            this.configSupport = configSupport;
            this.variableContext = variableContext;
            this.featureContext = featureContext;
            this.scenarioContext = scenarioContext;

            Setup();
        }

        public void Setup()
        {
            if (configSupport.Config != null)
            {
                var tags = getAllTags();

                tags.ForEach(tag =>
                {
                    var parameter = configSupport.Config.Parameters.SingleOrDefault(_ => _.Name == tag);
                    if (parameter != null)
                    {
                        foreach (var param in parameter.Params)
                        {
                            variableContext.SetVariable(param.Key, param.Value.GetType(), param.Value);
                        }
                    }
                });

                configSupport.Config.Reports.ToList().ForEach(report =>
                {
                    foreach(var rp in Enum.GetNames(typeof(ReportType)))
                    {
                        if (rp.ToString().Equals(report))
                        {
                            variableContext.SetVariable(rp.ToString(), typeof(bool), true);
                        }
                        else
                        {
                            variableContext.SetVariable(rp.ToString(), typeof(bool), false);
                        }
                    }
                });
            }
        }

        private List<string> getAllTags()
        {
            var featureTags = featureContext.FeatureInfo.Tags;
            var scenarioTags = scenarioContext.ScenarioInfo.Tags;

            return scenarioTags.Concat(featureTags).Concat(commonTag).OrderBy(t => t).ToList();
        }
    }
}