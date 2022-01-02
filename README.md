[license]: https://github.com/alfa-laboratory/AlfaBank.AFT.Core.Library/blob/master/LICENSE "MIT License 2019"
[wiki]: https://github.com/alfa-laboratory/AlfaBank.AFT.Core.Library/wiki "Wiki"

# AlfaBank.AFT.Core.Library [![build](https://ci.appveyor.com/api/projects/status/j33s710ss3f0nf4u?svg=true)](https://ci.appveyor.com/project/egorsh0/alfabank-aft-core-library) [![license](https://img.shields.io/github/license/alfa-laboratory/AlfaBank.AFT.Core.Library)](https://github.com/alfa-laboratory/AlfaBank.AFT.Core.Library/blob/master/LICENSE)
Набор библиотек с шагами для **BDD** тестирования баз данных, веб-сервисов и WebUI

## Library
 ##### *AlfaBank.AFT.Core* ![AlfaBank.AFT.Core](https://img.shields.io/nuget/dt/AlfaBank.AFT.Core)
 ##### *AlfaBank.AFT.Core.Library.Common* ![AlfaBank.AFT.Core.Library.Common](https://img.shields.io/nuget/dt/AlfaBank.AFT.Core.Library.Common) 
 ##### *AlfaBank.AFT.Core.Library.Database* ![AlfaBank.AFT.Core.Library.Database](https://img.shields.io/nuget/dt/AlfaBank.AFT.Core.Library.Database)
 ##### *AlfaBank.AFT.Core.Library.Service* ![AlfaBank.AFT.Core.Library.Service](https://img.shields.io/nuget/dt/AlfaBank.AFT.Core.Library.Service)
 ##### *AlfaBank.AFT.Core.Library.Web* ![AlfaBank.AFT.Core.Library.Web](https://img.shields.io/nuget/dt/AlfaBank.AFT.Core.Library.Web)

### Состав библиотек

* AlfaBank.AFT.Core	содержит логику для:
  - генераций уникальных текстовых/числовых значений;
  - генерации уникальных значений даты/времени;
  - генерации уникальных номеров телефонов;
  - подключения к БД и выполнени¤ запросов;
  - выполнение запросов к веб-сервисам;
  - работе с WebUI.
* AlfaBank.AFT.Core.Library.Common содержит **готовые** шаги для:
  - генераций уникальных значений (тестовые, числовые, дата-время)
  - основные проверки.
* AlfaBank.AFT.Core.Library.Database содержит **готовые** шаги для:
  - подключения к базе данных (SQL Server);
  - выполнения Select, Insert, Update, Delete запросов;
  - выполнения Stored Procedure.
* AlfaBAnk.AFT.Core.Library.Service содержит **готовые** шаги для:
  - выполнения запросов REST;
  - выполнения запросов SOAP;
  - сохранения результатов вызова в виде объекта, текста, json или xml;
  - проверки статуса выполнения запроса.

## Documentation

All the documentation is available [on our site][wiki].

## Как запустить?

В проект необходимо добавить файл **specflow.json**, в котором описывается используемый язык ключевых слов и те *assembly*, в которых находятся шаги

``` json
{
  "language": {
    "feature": "en-EN"
  },
  "stepAssemblies": [
    {
      "assembly": "AlfaBank.AFT.Core.Library.Common"
    }
  ]
}
```

Дополнительно, необходимо проверить, что в *.csproj файле прописана связь с файлом:

``` csproj
  <ItemGroup>
    <None Update="specflow.json">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </None>
  </ItemGroup>
```

## Dependencies 
1. Net Core 2.2 or Net Standart
1. SpecFlow 3.0.225
2. SpecFlow.Tools.MsBuild.Generation 3.0.225
3. **TestFramework** (xUnit, nUnit and etc) (xUnit 2.4.1)
4. SpecFlow.**TestFramework** 3.0.225
5. AlfaBank.AFT.Core.Library.**Type**

## Contacts

[Telegram](https://t.me/AlfaBankAFTCore)

## License

The AlfaBank.AFT.Core.Library is released of the [MIT License 2020][license].
