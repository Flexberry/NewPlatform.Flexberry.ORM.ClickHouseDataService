



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


CREATE TABLE "�������" (

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

 "PoleDecimal" Decimal128(29),

 "PoleBool" UInt8,

 "PoleNullableInt" Nullable(Int32),

 "PoleNullableDecimal" Nullable(Decimal128(29)),

 "PoleNullableDateTime" Nullable(DateTime),

 "PoleNullInt" NullInt,

 "PoleNullDateTime" NullDateTime,

 "PoleNullFloat" NullFloat,

 "PoleNullDouble" NullDouble,

 "PoleNullDecimal" NullDecimal,

 "PoleGuid" UUID,

 "PoleNullGuid" NullGuid,

 "PoleEnum" String,

 "PoleChar" UInt16,

 "PoleNullChar" NullChar

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "CombinedTypesUsageProviderTest" (

 "primaryKey" UUID,

 "Name" String,

 "DataObjectForTest_m0" UUID,

 "TypeUsageProviderTestClass" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "�������" (

 "primaryKey" UUID,

 "��������" String,

 "��������" String,

 "����������" Nullable(DateTime),

 "�������������" Nullable(DateTime),

 "������������" Nullable(DateTime),

 "���������������" Nullable(DateTime),

 "���������" String,

 "�����������_m0" UUID

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


CREATE TABLE "����������" (

 "primaryKey" UUID,

 "��������������" Int32

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "������" (

 "primaryKey" UUID,

 "��������" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "������������" (

 "primaryKey" UUID,

 "�����" String,

 "���" String,

 "EMail" String,

 "���������������" Nullable(DateTime)

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "TypeNameUsageProviderTestClass" (

 "primaryKey" UUID,

 "Name" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "����������1" (

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


CREATE TABLE "�������" (

 "primaryKey" UUID,

 "������������" String,

 "������������" Int32,

 "���������" UInt8,

 "���������������" UUID,

 "�������" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Dish2" (

 "primaryKey" UUID,

 "DishName" String,

 "MainIngridient_m0" UUID,

 "MainIngridient_m1" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "��������������" (

 "primaryKey" UUID,

 "���������������" Int32,

 "��������" String,

 "���" Float64,

 "������������" UInt8,

 "�������_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "AuditAgregatorObject" (

 "primaryKey" UUID,

 "Login" String,

 "Name" String,

 "Surname" String,

 "MasterObject" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "�������������" (

 "primaryKey" UUID,

 "���" String

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

 "PoleDecimal" Decimal128(29),

 "PoleBool" UInt8,

 "PoleNullableInt" Nullable(Int32),

 "PoleNullableDecimal" Nullable(Decimal128(29)),

 "PoleNullableDateTime" Nullable(DateTime),

 "PoleNullInt" NullInt,

 "PoleNullDateTime" NullDateTime,

 "PoleNullFloat" NullFloat,

 "PoleNullDouble" NullDouble,

 "PoleNullDecimal" NullDecimal,

 "PoleGuid" UUID,

 "PoleNullGuid" NullGuid,

 "PoleEnum" String,

 "PoleChar" UInt16,

 "PoleNullChar" NullChar,

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


CREATE TABLE "�������" (

 "primaryKey" UUID,

 "����" DateTime,

 "���" String,

 "����_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "��������������" (

 "primaryKey" UUID,

 "��������" String,

 "��������������" Float64,

 "��������_m0" UUID,

 "����_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "��������������" (

 "primaryKey" UUID,

 "���������������" Int32

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "TypeUsageProviderTestClassChil" (

 "primaryKey" UUID,

 "Name" String,

 "DataObjectForTest_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "��������" (

 "primaryKey" UUID,

 "����" String,

 "��������_m0" UUID,

 "����_m0" UUID

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

 "������_m0" UUID,

 "������_m1" UUID,

 "������_m2" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "CabbageSalad" (

 "primaryKey" UUID,

 "CabbageSaladName" String,

 "Cabbage2" UUID,

 "Cabbage1" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "��������������" (

 "primaryKey" UUID,

 "��������������" Float64,

 "�����������" String,

 "�������_m0" UUID,

 "��������������" UUID,

 "����_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "Adress2" (

 "primaryKey" UUID,

 "HomeNumber" Int32,

 "Country_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "������" (

 "primaryKey" UUID,

 "����������" DateTime,

 "������������" Float64,

 "�����������" Int32,

 "����������" String,

 "������" UUID,

 "���������������" UUID

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


CREATE TABLE "�����" (

 "primaryKey" UUID,

 "������" String,

 "������������" Nullable(DateTime),

 "���" String,

 "�������������" String,

 "�����������" UInt8,

 "��������������" Nullable(Int32),

 "���������������" Nullable(Int32),

 "����" KeyGuid,

 "������" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "���������" (

 "primaryKey" UUID,

 "��������" String,

 "���������������" DateTime

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


CREATE TABLE "�����" (

 "primaryKey" UUID,

 "������" String,

 "���������������" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "�������" (

 "primaryKey" UUID,

 "�������������" String,

 "��������" Int32,

 "�����" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "DataObjectForTest" (

 "primaryKey" UUID,

 "Name" String,

 "Height" Int32,

 "BirthDate" SystemNullableDateTime,

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


CREATE TABLE "����" (

 "primaryKey" UUID,

 "���������" String,

 "��������" String,

 "�����������" Float64,

 "�����_m0" UUID,

 "�������_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "InformationTestClass4" (

 "primaryKey" UUID,

 "StringPropForInfTestClass4" String,

 "MasterOfInformationTestClass3" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "����" (

 "primaryKey" UUID,

 "����" String,

 "������" Int32,

 "������������" Nullable(DateTime),

 "��������������" UInt8,

 "�������" String,

 "�����" Int32,

 "������Double" Float64,

 "������Float" Float32,

 "������NullableInt" SystemNullableInt,

 "������Decimal" Decimal128(29),

 "������NullableDecimal" SystemNullableDecimal,

 "������NullableChar" SystemNullableChar,

 "�������_m0" UUID,

 "�����_m0" UUID

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


CREATE TABLE "�������" (

 "primaryKey" UUID,

 "��������" String,

 "���������" UInt8

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "��������" (

 "primaryKey" UUID,

 "���" String

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


CREATE TABLE "���" (

 "primaryKey" UUID,

 "��������" String,

 "�������" Int32,

 "����������" UInt8,

 "��������������" Nullable(DateTime),

 "������" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "������" (

 "primaryKey" UUID,

 "���" String,

 "��������" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "�������������" (

 "primaryKey" UUID,

 "���������������" Int32,

 "�������������" UUID,

 "����������_m0" UUID

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

 "LinkToMaster1" KeyGuid,

 "LinkToMaster2" KeyGuid

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "FullTypesMainAgregator" (

 "primaryKey" UUID,

 "PoleInt" Int32,

 "PoleDateTime" DateTime,

 "PoleString" String,

 "PoleFloat" Float32,

 "PoleDouble" Float64,

 "PoleDecimal" Decimal128(29),

 "PoleBool" UInt8,

 "PoleNullableInt" Nullable(Int32),

 "PoleNullableDecimal" Nullable(Decimal128(29)),

 "PoleNullableDateTime" Nullable(DateTime),

 "PoleNullInt" NullInt,

 "PoleNullDateTime" NullDateTime,

 "PoleNullFloat" NullFloat,

 "PoleNullDouble" NullDouble,

 "PoleNullDecimal" NullDecimal,

 "PoleGuid" UUID,

 "PoleNullGuid" NullGuid,

 "PoleEnum" String,

 "PoleChar" UInt16,

 "PoleNullChar" NullChar,

 "FullTypesMaster1_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "������" (

 "primaryKey" UUID,

 "��������" String,

 "����" KeyGuid,

 "��������" UUID,

 "���������" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "ComputedMaster" (

 "primaryKey" UUID,

 "MasterField1" String,

 "MasterField2" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "��������������" (

 "primaryKey" UUID,

 "���������������" Int32,

 "������" String,

 "��������_m0" UUID,

 "����������_m0" UUID

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


CREATE TABLE "�������" (

 "primaryKey" UUID,

 "�����������" DateTime,

 "������������" Float64,

 "������1" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "AuditClassWithDisabledAudit" (

 "primaryKey" UUID,

 "CreateTime" DATETIME,

 "Creator" String,

 "EditTime" DATETIME,

 "Editor" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");


CREATE TABLE "������������" (

 "primaryKey" UUID,

 "����" String,

 "�������_m0" UUID

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

 "PoleDecimal" Decimal128(29),

 "PoleBool" UInt8,

 "PoleNullableInt" Nullable(Int32),

 "PoleNullableDecimal" Nullable(Decimal128(29)),

 "PoleNullableDateTime" Nullable(DateTime),

 "PoleNullInt" NullInt,

 "PoleNullDateTime" NullDateTime,

 "PoleNullFloat" NullFloat,

 "PoleNullDouble" NullDouble,

 "PoleNullDecimal" NullDecimal,

 "PoleGuid" UUID,

 "PoleNullGuid" NullGuid,

 "PoleEnum" String,

 "PoleChar" UInt16,

 "PoleNullChar" NullChar,

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


CREATE TABLE "����������2" (

 "primaryKey" UUID

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


CREATE TABLE "�������" (

 "primaryKey" UUID,

 "���������������" Int32,

 "���" Int32,

 "��������" String,

 "���" String,

 "������������" Nullable(DateTime),

 "����" UUID,

 "�����������" UUID,

 "����_m0" UUID,

 "����" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");




