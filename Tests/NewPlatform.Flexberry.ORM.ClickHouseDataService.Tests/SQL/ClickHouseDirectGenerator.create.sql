



CREATE TABLE "Place2" (

 "primaryKey" UUID,

 "PlaceName" String,

 "TomorrowTeritory_m0" UUID,

 "TomorrowTeritory_m1" UUID,

 "TodayTerritory_m0" UUID,

 "TodayTerritory_m1" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "SomeMasterClass" (

 "primaryKey" UUID,

 "FieldA" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "МастерМ" (

 "primaryKey" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "FullTypesMaster1" (

 "primaryKey" UUID,

 "PoleInt" Int32,

 "PoleUInt" UInt32,

 "PoleDateTime" DateTime,

 "PoleString" String,

 "PoleFloat" Float32,

 "PoleDouble" Float64,

 "PoleDecimal" Decimal128(27),

 "PoleBool" UInt8,

 "PoleNullableInt" Nullable(Int32),

 "PoleNullableDecimal" Nullable(Decimal128(27)),

 "PoleNullableDateTime" Nullable(DateTime),

 "PoleNullInt" Nullable(Int32),

 "PoleNullDateTime" Nullable(DateTime),

 "PoleNullFloat" Nullable(Float32),

 "PoleNullDouble" Nullable(Float64),

 "PoleNullDecimal" Nullable(Decimal128(27)),

 "PoleGuid" UUID,

 "PoleNullGuid" Nullable(UUID),

 "PoleEnum" String,

 "PoleChar" UInt16,

 "PoleNullChar" Nullable(UInt16)

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "CombinedTypesUsageProviderTest" (

 "primaryKey" UUID,

 "Name" String,

 "DataObjectForTest_m0" UUID,

 "TypeUsageProviderTestClass" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Конкурс" (

 "primaryKey" UUID,

 "Название" String,

 "Описание" String,

 "ДатаНачала" Nullable(DateTime),

 "ДатаОкончания" Nullable(DateTime),

 "НачалоОценки" Nullable(DateTime),

 "ОкончаниеОценки" Nullable(DateTime),

 "Состоятие" String,

 "Организатор_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Territory2" (

 "primaryKey" UUID,

 "XCoordinate" Int32,

 "YCoordinate" Int32

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "StoredClass" (

 "primaryKey" UUID,

 "StoredProperty" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "ХозДоговор" (

 "primaryKey" UUID,

 "НомХозДоговора" Int32

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Страна" (

 "primaryKey" UUID,

 "Название" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Пользователь" (

 "primaryKey" UUID,

 "Логин" String,

 "ФИО" String,

 "EMail" String,

 "ДатаРегистрации" Nullable(DateTime)

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "TypeNameUsageProviderTestClass" (

 "primaryKey" UUID,

 "Name" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "НаследникМ1" (

 "primaryKey" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "CabbagePart2" (

 "primaryKey" UUID,

 "PartName" String,

 "Cabbage" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "InformationTestClass6" (

 "primaryKey" UUID,

 "StringPropForInfTestClass6" String,

 "ExampleOfClassWithCaptions" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Берлога" (

 "primaryKey" UUID,

 "Наименование" String,

 "Комфортность" Int32,

 "Заброшена" UInt8,

 "ЛесРасположения" UUID,

 "Медведь" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Dish2" (

 "primaryKey" UUID,

 "DishName" String,

 "MainIngridient_m0" UUID,

 "MainIngridient_m1" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "КритерийОценки" (

 "primaryKey" UUID,

 "ПорядковыйНомер" Int32,

 "Описание" String,

 "Вес" Float64,

 "Обязательный" UInt8,

 "Конкурс_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "AuditAgregatorObject" (

 "primaryKey" UUID,

 "Login" String,

 "Name" String,

 "Surname" String,

 "MasterObject" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "ИнспПоКредиту" (

 "primaryKey" UUID,

 "ФИО" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "TypeUsageProviderTestClass" (

 "primaryKey" UUID,

 "Name" String,

 "DataObjectForTest_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "FullTypesDetail1" (

 "primaryKey" UUID,

 "PoleInt" Int32,

 "PoleDateTime" DateTime,

 "PoleString" String,

 "PoleFloat" Float32,

 "PoleDouble" Float64,

 "PoleDecimal" Decimal128(27),

 "PoleBool" UInt8,

 "PoleNullableInt" Nullable(Int32),

 "PoleNullableDecimal" Nullable(Decimal128(27)),

 "PoleNullableDateTime" Nullable(DateTime),

 "PoleNullInt" Nullable(Int32),

 "PoleNullDateTime" Nullable(DateTime),

 "PoleNullFloat" Nullable(Float32),

 "PoleNullDouble" Nullable(Float64),

 "PoleNullDecimal" Nullable(Decimal128(27)),

 "PoleGuid" UUID,

 "PoleNullGuid" Nullable(UUID),

 "PoleEnum" String,

 "PoleChar" UInt16,

 "PoleNullChar" Nullable(UInt16),

 "FullTypesMainAgregator_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Apparatus2" (

 "primaryKey" UUID,

 "ApparatusName" String,

 "Exporter_m0" UUID,

 "Maker_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Region" (

 "primaryKey" UUID,

 "RegionName" String,

 "Country2_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Перелом" (

 "primaryKey" UUID,

 "Дата" DateTime,

 "Тип" String,

 "Лапа_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "ЗначениеКритер" (

 "primaryKey" UUID,

 "Значение" String,

 "СредОценкаЭксп" Float64,

 "Критерий_m0" UUID,

 "Идея_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "ИсточникФинанс" (

 "primaryKey" UUID,

 "НомИсточникаФин" Int32

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "TypeUsageProviderTestClassChil" (

 "primaryKey" UUID,

 "Name" String,

 "DataObjectForTest_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "ФайлИдеи" (

 "primaryKey" UUID,

 "Файл" String,

 "Владелец_m0" UUID,

 "Идея_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "InformationTestClass3" (

 "primaryKey" UUID,

 "StringPropForInfTestClass3" String,

 "InformationTestClass2" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "TestClassA" (

 "primaryKey" UUID,

 "Name" String,

 "Value" Int32,

 "Мастер_m0" UUID,

 "Мастер_m1" UUID,

 "Мастер_m2" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "CabbageSalad" (

 "primaryKey" UUID,

 "CabbageSaladName" String,

 "Cabbage2" UUID,

 "Cabbage1" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "ОценкаЭксперта" (

 "primaryKey" UUID,

 "ЗначениеОценки" Float64,

 "Комментарий" String,

 "Эксперт_m0" UUID,

 "ЗначениеКритер" UUID,

 "Идея_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Adress2" (

 "primaryKey" UUID,

 "HomeNumber" Int32,

 "Country_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Кредит" (

 "primaryKey" UUID,

 "ДатаВыдачи" DateTime,

 "СуммаКредита" Float64,

 "СрокКредита" Int32,

 "ВидКредита" String,

 "Клиент" UUID,

 "ИнспекторПоКред" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "AuditMasterMasterObject" (

 "primaryKey" UUID,

 "Login" String,

 "Name" String,

 "Surname" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Country2" (

 "primaryKey" UUID,

 "CountryName" String,

 "XCoordinate" Int32,

 "YCoordinate" Int32

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "AuditMasterObject" (

 "primaryKey" UUID,

 "Login" String,

 "Name" String,

 "Surname" String,

 "MasterObject" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "clb" (

 "primaryKey" UUID,

 "ref1" UUID,

 "ref2" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Кошка" (

 "primaryKey" UUID,

 "Кличка" String,

 "ДатаРождения" Nullable(DateTime),

 "Тип" String,

 "ПородаСтрокой" String,

 "Агрессивная" UInt8,

 "КолвоУсовСлева" Nullable(Int32),

 "КолвоУсовСправа" Nullable(Int32),

 "Ключ" UUID,

 "Порода" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "ТипПороды" (

 "primaryKey" UUID,

 "Название" String,

 "ДатаРегистрации" DateTime

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "НаследникМ2" (

 "primaryKey" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Cabbage2" (

 "primaryKey" UUID,

 "Type" String,

 "Name" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "AuditClassWithSettings" (

 "primaryKey" UUID,

 "Name" String,

 "CreateTime" DATETIME,

 "Creator" String,

 "EditTime" DATETIME,

 "Editor" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Блоха" (

 "primaryKey" UUID,

 "Кличка" String,

 "МедведьОбитания" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Котенок" (

 "primaryKey" UUID,

 "КличкаКотенка" String,

 "Глупость" Int32,

 "Кошка" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "DataObjectForTest" (

 "primaryKey" UUID,

 "Name" String,

 "Height" Int32,

 "BirthDate" Nullable(DateTime),

 "Gender" UInt8

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Plant2" (

 "primaryKey" UUID,

 "Name" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "MasterClass" (

 "primaryKey" UUID,

 "StringMasterProperty" String,

 "InformationTestClass3_m0" UUID,

 "InformationTestClass2" UUID,

 "InformationTestClass_m0" UUID,

 "InformationTestClass_m1" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Идея" (

 "primaryKey" UUID,

 "Заголовок" String,

 "Описание" String,

 "СуммаБаллов" Float64,

 "Автор_m0" UUID,

 "Конкурс_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "InformationTestClass4" (

 "primaryKey" UUID,

 "StringPropForInfTestClass4" String,

 "MasterOfInformationTestClass3" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Лапа" (

 "primaryKey" UUID,

 "Цвет" String,

 "Размер" Int32,

 "ДатаРождения" Nullable(DateTime),

 "БылиЛиПереломы" UInt8,

 "Сторона" String,

 "Номер" Int32,

 "РазмерDouble" Float64,

 "РазмерFloat" Float32,

 "РазмерNullableInt" Nullable(Int32),

 "РазмерDecimal" Decimal128(27),

 "РазмерNullableDecimal" Nullable(Decimal128(27)),

 "РазмерNullableChar" Nullable(UInt16),

 "ТипЛапы_m0" UUID,

 "Кошка_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "SomeDetailClass" (

 "primaryKey" UUID,

 "FieldB" String,

 "ClassA" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Human2" (

 "primaryKey" UUID,

 "HumanName" String,

 "TodayHome_m0" UUID,

 "TodayHome_m1" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "SimpleDataObject" (

 "primaryKey" UUID,

 "Name" String,

 "Age" Int32

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "ТипЛапы" (

 "primaryKey" UUID,

 "Название" String,

 "Актуально" UInt8

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Личность" (

 "primaryKey" UUID,

 "ФИО" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "InformationTestClass2" (

 "primaryKey" UUID,

 "StringPropertyForInfTestClass2" String,

 "InformationTestClass_m0" UUID,

 "InformationTestClass_m1" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "DetailClass" (

 "primaryKey" UUID,

 "Detailproperty" String,

 "MasterClass_m0" UUID,

 "MasterClass_m1" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "cla" (

 "primaryKey" UUID,

 "info" String,

 "parent" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Лес" (

 "primaryKey" UUID,

 "Название" String,

 "Площадь" Int32,

 "Заповедник" UInt8,

 "ДатаПослОсмотр" Nullable(DateTime),

 "Страна" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Клиент" (

 "primaryKey" UUID,

 "ФИО" String,

 "Прописка" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "ИФХозДоговора" (

 "primaryKey" UUID,

 "НомерИФХозДогов" Int32,

 "ИсточникФинан" UUID,

 "ХозДоговор_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "ComputedDetail" (

 "primaryKey" UUID,

 "DetailField1" String,

 "DetailField2" String,

 "ComputedMaster" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "InformationTestClassChild" (

 "primaryKey" UUID,

 "PublicStringProperty" String,

 "StringPropertyForInfTestClass" String,

 "IntPropertyForInfTestClass" Nullable(Int32),

 "BoolPropertyForInfTestClass" UInt8

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "ClassWithCaptions" (

 "primaryKey" UUID,

 "InformationTestClass4" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "DataObjectWithKeyGuid" (

 "primaryKey" UUID,

 "LinkToMaster1" UUID,

 "LinkToMaster2" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "FullTypesMainAgregator" (

 "primaryKey" UUID,

 "PoleInt" Int32,

 "PoleDateTime" DateTime,

 "PoleString" String,

 "PoleFloat" Float32,

 "PoleDouble" Float64,

 "PoleDecimal" Decimal128(27),

 "PoleBool" UInt8,

 "PoleNullableInt" Nullable(Int32),

 "PoleNullableDecimal" Nullable(Decimal128(27)),

 "PoleNullableDateTime" Nullable(DateTime),

 "PoleNullInt" Nullable(Int32),

 "PoleNullDateTime" Nullable(DateTime),

 "PoleNullFloat" Nullable(Float32),

 "PoleNullDouble" Nullable(Float64),

 "PoleNullDecimal" Nullable(Decimal128(27)),

 "PoleGuid" UUID,

 "PoleNullGuid" Nullable(UUID),

 "PoleEnum" String,

 "PoleChar" UInt16,

 "PoleNullChar" Nullable(UInt16),

 "FullTypesMaster1_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Порода" (

 "primaryKey" UUID,

 "Название" String,

 "Ключ" UUID,

 "Иерархия" UUID,

 "ТипПороды" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "ComputedMaster" (

 "primaryKey" UUID,

 "MasterField1" String,

 "MasterField2" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "УчастникХозДог" (

 "primaryKey" UUID,

 "НомУчастнХозДог" Int32,

 "Статус" String,

 "Личность_m0" UUID,

 "ХозДоговор_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Soup2" (

 "primaryKey" UUID,

 "SoupName" String,

 "CabbageType" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "DateField" (

 "primaryKey" UUID,

 "Date" DateTime

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "InformationTestClass" (

 "primaryKey" UUID,

 "PublicStringProperty" String,

 "StringPropertyForInfTestClass" String,

 "IntPropertyForInfTestClass" Nullable(Int32),

 "BoolPropertyForInfTestClass" UInt8

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Выплаты" (

 "primaryKey" UUID,

 "ДатаВыплаты" DateTime,

 "СуммаВыплаты" Float64,

 "Кредит1" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "AuditClassWithDisabledAudit" (

 "primaryKey" UUID,

 "CreateTime" DATETIME,

 "Creator" String,

 "EditTime" DATETIME,

 "Editor" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "ДокККонкурсу" (

 "primaryKey" UUID,

 "Файл" String,

 "Конкурс_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "AuditClassWithoutSettings" (

 "primaryKey" UUID,

 "Name" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "FullTypesDetail2" (

 "primaryKey" UUID,

 "PoleInt" Int32,

 "PoleDateTime" DateTime,

 "PoleString" String,

 "PoleFloat" Float32,

 "PoleDouble" Float64,

 "PoleDecimal" Decimal128(27),

 "PoleBool" UInt8,

 "PoleNullableInt" Nullable(Int32),

 "PoleNullableDecimal" Nullable(Decimal128(27)),

 "PoleNullableDateTime" Nullable(DateTime),

 "PoleNullInt" Nullable(Int32),

 "PoleNullDateTime" Nullable(DateTime),

 "PoleNullFloat" Nullable(Float32),

 "PoleNullDouble" Nullable(Float64),

 "PoleNullDecimal" Nullable(Decimal128(27)),

 "PoleGuid" UUID,

 "PoleNullGuid" Nullable(UUID),

 "PoleEnum" String,

 "PoleChar" UInt16,

 "PoleNullChar" Nullable(UInt16),

 "FullTypesMainAgregator" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "ForKeyStorageTest" (

 "StorageForKey" String

) ENGINE = MergeTree() ORDER BY ("StorageForKey");


CREATE TABLE "Salad2" (

 "primaryKey" UUID,

 "SaladName" String,

 "Ingridient2_m0" UUID,

 "Ingridient2_m1" UUID,

 "Ingridient1_m0" UUID,

 "Ingridient1_m1" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "AggregatorUpdateObjectTest" (

 "primaryKey" UUID,

 "AggregatorName" String,

 "Detail" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "DetailUpdateObjectTest" (

 "primaryKey" UUID,

 "DetailName" String,

 "Master" UUID,

 "AggregatorUpdateObjectTest" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "MasterUpdateObjectTest" (

 "primaryKey" UUID,

 "MasterName" String,

 "Detail" UUID,

 "AggregatorUpdateObjectTest" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Медведь" (

 "primaryKey" UUID,

 "ПорядковыйНомер" Int32,

 "Вес" Int32,

 "ЦветГлаз" String,

 "Пол" String,

 "ДатаРождения" Nullable(DateTime),

 "Папа" UUID,

 "ЛесОбитания" UUID,

 "Друг_m0" UUID,

 "Мама" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");




