﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Лапа.
    /// </summary>
    // *** Start programmer edit section *** (Лапа CustomAttributes)

    // *** End programmer edit section *** (Лапа CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("k_ЛапаE", new string[] {
            "Цвет as \'Цвет\'",
            "Размер as \'Размер\'",
            "ДатаРождения as \'Дата рождения\'",
            "БылиЛиПереломы as \'Были ли переломы\'",
            "Сторона as \'Сторона\'",
            "Номер as \'Номер\'",
            "ТипЛапы as \'Тип лапы\'",
            "ТипЛапы.Название as \'Название\'"}, Hidden=new string[] {
            "Номер",
            "ТипЛапы.Название"})]
    [AssociatedDetailViewAttribute("k_ЛапаE", "Перелом", "k_ПереломE", true, "", "Перелом", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("k_ЛапаE", "ТипЛапы", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    [View("КИЛ_ЛапаE", new string[] {
            "Номер as \'Порядковый номер\'",
            "РазмерСтрокой",
            "Цвет",
            "Размер",
            "ДатаРождения",
            "БылиЛиПереломы",
            "ТипЛапы",
            "Файл"}, Hidden=new string[] {
            "РазмерСтрокой"})]
    [AssociatedDetailViewAttribute("КИЛ_ЛапаE", "Перелом", "ПереломD", true, "|Лапы", "", true, new string[] {
            ""})]
    [View("ЛапаE", new string[] {
            "Цвет as \'Цвет\'",
            "Размер as \'Размер\'",
            "ДатаРождения as \'Дата рождения\'",
            "БылиЛиПереломы as \'Были ли переломы\'",
            "Сторона as \'Сторона\'",
            "Номер as \'Номер\'",
            "ТипЛапы as \'Тип лапы\'",
            "ТипЛапы.Название as \'Название\'",
            "РазмерСтрокой",
            "РазмерDouble",
            "РазмерFloat",
            "РазмерNullableInt",
            "РазмерDecimal",
            "РазмерNullableDecimal",
            "РазмерChar",
            "РазмерNullableChar",
            "Кошка",
            "Кошка.Кличка"}, Hidden=new string[] {
            "ТипЛапы.Название"})]
    [AssociatedDetailViewAttribute("ЛапаE", "Перелом", "ПереломE", true, "", "Перелом", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("ЛапаE", "ТипЛапы", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    [View("ЛапаFull", new string[] {
            "Цвет as \'Цвет\'",
            "Размер as \'Размер\'",
            "ДатаРождения as \'Дата рождения\'",
            "БылиЛиПереломы as \'Были ли переломы\'",
            "Сторона as \'Сторона\'",
            "Номер as \'Номер\'",
            "ТипЛапы as \'Тип лапы\'",
            "ТипЛапы.Название as \'Название\'",
            "Кошка",
            "Кошка.Кличка"}, Hidden=new string[] {
            "ТипЛапы.Название",
            "Кошка"})]
    [AssociatedDetailViewAttribute("ЛапаFull", "Перелом", "ПереломE", true, "", "Перелом", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("ЛапаFull", "ТипЛапы", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    [View("ЛапаShort", new string[] {
            "Размер as \'Размер\'",
            "ДатаРождения as \'Дата рождения\'",
            "ТипЛапы as \'Тип лапы\'",
            "ТипЛапы.Название as \'Название\'"}, Hidden=new string[] {
            "ТипЛапы.Название"})]
    [AssociatedDetailViewAttribute("ЛапаShort", "Перелом", "ПереломE", true, "", "Перелом", true, new string[] {
            ""})]
    public class Лапа : ICSSoft.STORMNET.DataObject
    {
        
        private string fЦвет;
        
        private int fРазмер;
        
        private ICSSoft.STORMNET.UserDataTypes.NullableDateTime fДатаРождения;
        
        private bool fБылиЛиПереломы;
        
        private NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Сторона fСторона;
        
        private int fНомер;
        
        private double fРазмерDouble;
        
        private float fРазмерFloat;
        
        private System.Nullable<int> fРазмерNullableInt;
        
        private decimal fРазмерDecimal;
        
        private System.Nullable<decimal> fРазмерNullableDecimal;
        
        private System.Nullable<char> fРазмерNullableChar;
        
        private NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.ТипЛапы fТипЛапы;
        
        private NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.DetailArrayOfПерелом fПерелом;
        
        private NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Кошка fКошка;
        
        // *** Start programmer edit section *** (Лапа CustomMembers)

        // *** End programmer edit section *** (Лапа CustomMembers)

        
        /// <summary>
        /// Цвет.
        /// </summary>
        // *** Start programmer edit section *** (Лапа.Цвет CustomAttributes)

        // *** End programmer edit section *** (Лапа.Цвет CustomAttributes)
        [StrLen(255)]
        public virtual string Цвет
        {
            get
            {
                // *** Start programmer edit section *** (Лапа.Цвет Get start)

                // *** End programmer edit section *** (Лапа.Цвет Get start)
                string result = this.fЦвет;
                // *** Start programmer edit section *** (Лапа.Цвет Get end)

                // *** End programmer edit section *** (Лапа.Цвет Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Лапа.Цвет Set start)

                // *** End programmer edit section *** (Лапа.Цвет Set start)
                this.fЦвет = value;
                // *** Start programmer edit section *** (Лапа.Цвет Set end)

                // *** End programmer edit section *** (Лапа.Цвет Set end)
            }
        }
        
        /// <summary>
        /// Размер.
        /// </summary>
        // *** Start programmer edit section *** (Лапа.Размер CustomAttributes)

        // *** End programmer edit section *** (Лапа.Размер CustomAttributes)
        public virtual int Размер
        {
            get
            {
                // *** Start programmer edit section *** (Лапа.Размер Get start)

                // *** End programmer edit section *** (Лапа.Размер Get start)
                int result = this.fРазмер;
                // *** Start programmer edit section *** (Лапа.Размер Get end)

                // *** End programmer edit section *** (Лапа.Размер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Лапа.Размер Set start)

                // *** End programmer edit section *** (Лапа.Размер Set start)
                this.fРазмер = value;
                // *** Start programmer edit section *** (Лапа.Размер Set end)

                // *** End programmer edit section *** (Лапа.Размер Set end)
            }
        }
        
        /// <summary>
        /// ДатаРождения.
        /// </summary>
        // *** Start programmer edit section *** (Лапа.ДатаРождения CustomAttributes)

        // *** End programmer edit section *** (Лапа.ДатаРождения CustomAttributes)
        public virtual ICSSoft.STORMNET.UserDataTypes.NullableDateTime ДатаРождения
        {
            get
            {
                // *** Start programmer edit section *** (Лапа.ДатаРождения Get start)

                // *** End programmer edit section *** (Лапа.ДатаРождения Get start)
                ICSSoft.STORMNET.UserDataTypes.NullableDateTime result = this.fДатаРождения;
                // *** Start programmer edit section *** (Лапа.ДатаРождения Get end)

                // *** End programmer edit section *** (Лапа.ДатаРождения Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Лапа.ДатаРождения Set start)

                // *** End programmer edit section *** (Лапа.ДатаРождения Set start)
                this.fДатаРождения = value;
                // *** Start programmer edit section *** (Лапа.ДатаРождения Set end)

                // *** End programmer edit section *** (Лапа.ДатаРождения Set end)
            }
        }
        
        /// <summary>
        /// БылиЛиПереломы.
        /// </summary>
        // *** Start programmer edit section *** (Лапа.БылиЛиПереломы CustomAttributes)

        // *** End programmer edit section *** (Лапа.БылиЛиПереломы CustomAttributes)
        public virtual bool БылиЛиПереломы
        {
            get
            {
                // *** Start programmer edit section *** (Лапа.БылиЛиПереломы Get start)

                // *** End programmer edit section *** (Лапа.БылиЛиПереломы Get start)
                bool result = this.fБылиЛиПереломы;
                // *** Start programmer edit section *** (Лапа.БылиЛиПереломы Get end)

                // *** End programmer edit section *** (Лапа.БылиЛиПереломы Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Лапа.БылиЛиПереломы Set start)

                // *** End programmer edit section *** (Лапа.БылиЛиПереломы Set start)
                this.fБылиЛиПереломы = value;
                // *** Start programmer edit section *** (Лапа.БылиЛиПереломы Set end)

                // *** End programmer edit section *** (Лапа.БылиЛиПереломы Set end)
            }
        }
        
        /// <summary>
        /// Сторона.
        /// </summary>
        // *** Start programmer edit section *** (Лапа.Сторона CustomAttributes)

        // *** End programmer edit section *** (Лапа.Сторона CustomAttributes)
        public virtual NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Сторона Сторона
        {
            get
            {
                // *** Start programmer edit section *** (Лапа.Сторона Get start)

                // *** End programmer edit section *** (Лапа.Сторона Get start)
                NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Сторона result = this.fСторона;
                // *** Start programmer edit section *** (Лапа.Сторона Get end)

                // *** End programmer edit section *** (Лапа.Сторона Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Лапа.Сторона Set start)

                // *** End programmer edit section *** (Лапа.Сторона Set start)
                this.fСторона = value;
                // *** Start programmer edit section *** (Лапа.Сторона Set end)

                // *** End programmer edit section *** (Лапа.Сторона Set end)
            }
        }
        
        /// <summary>
        /// Номер.
        /// </summary>
        // *** Start programmer edit section *** (Лапа.Номер CustomAttributes)

        // *** End programmer edit section *** (Лапа.Номер CustomAttributes)
        [Order()]
        public virtual int Номер
        {
            get
            {
                // *** Start programmer edit section *** (Лапа.Номер Get start)

                // *** End programmer edit section *** (Лапа.Номер Get start)
                int result = this.fНомер;
                // *** Start programmer edit section *** (Лапа.Номер Get end)

                // *** End programmer edit section *** (Лапа.Номер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Лапа.Номер Set start)

                // *** End programmer edit section *** (Лапа.Номер Set start)
                this.fНомер = value;
                // *** Start programmer edit section *** (Лапа.Номер Set end)

                // *** End programmer edit section *** (Лапа.Номер Set end)
            }
        }
        
        /// <summary>
        /// РазмерСтрокой.
        /// </summary>
        // *** Start programmer edit section *** (Лапа.РазмерСтрокой CustomAttributes)

        // *** End programmer edit section *** (Лапа.РазмерСтрокой CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        [StrLen(255)]
        [DataServiceExpression(typeof(ICSSoft.STORMNET.Business.MSSQLDataService), "cast(@Размер@ as VARCHAR)+\' размер\'")]
        public virtual string РазмерСтрокой
        {
            get
            {
                // *** Start programmer edit section *** (Лапа.РазмерСтрокой Get)

                return null;
                // *** End programmer edit section *** (Лапа.РазмерСтрокой Get)
            }
            set
            {
                // *** Start programmer edit section *** (Лапа.РазмерСтрокой Set)

                // *** End programmer edit section *** (Лапа.РазмерСтрокой Set)
            }
        }
        
        /// <summary>
        /// РазмерDouble.
        /// </summary>
        // *** Start programmer edit section *** (Лапа.РазмерDouble CustomAttributes)

        // *** End programmer edit section *** (Лапа.РазмерDouble CustomAttributes)
        public virtual double РазмерDouble
        {
            get
            {
                // *** Start programmer edit section *** (Лапа.РазмерDouble Get start)

                // *** End programmer edit section *** (Лапа.РазмерDouble Get start)
                double result = this.fРазмерDouble;
                // *** Start programmer edit section *** (Лапа.РазмерDouble Get end)

                // *** End programmer edit section *** (Лапа.РазмерDouble Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Лапа.РазмерDouble Set start)

                // *** End programmer edit section *** (Лапа.РазмерDouble Set start)
                this.fРазмерDouble = value;
                // *** Start programmer edit section *** (Лапа.РазмерDouble Set end)

                // *** End programmer edit section *** (Лапа.РазмерDouble Set end)
            }
        }
        
        /// <summary>
        /// РазмерFloat.
        /// </summary>
        // *** Start programmer edit section *** (Лапа.РазмерFloat CustomAttributes)

        // *** End programmer edit section *** (Лапа.РазмерFloat CustomAttributes)
        public virtual float РазмерFloat
        {
            get
            {
                // *** Start programmer edit section *** (Лапа.РазмерFloat Get start)

                // *** End programmer edit section *** (Лапа.РазмерFloat Get start)
                float result = this.fРазмерFloat;
                // *** Start programmer edit section *** (Лапа.РазмерFloat Get end)

                // *** End programmer edit section *** (Лапа.РазмерFloat Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Лапа.РазмерFloat Set start)

                // *** End programmer edit section *** (Лапа.РазмерFloat Set start)
                this.fРазмерFloat = value;
                // *** Start programmer edit section *** (Лапа.РазмерFloat Set end)

                // *** End programmer edit section *** (Лапа.РазмерFloat Set end)
            }
        }
        
        /// <summary>
        /// РазмерNullableInt.
        /// </summary>
        // *** Start programmer edit section *** (Лапа.РазмерNullableInt CustomAttributes)

        // *** End programmer edit section *** (Лапа.РазмерNullableInt CustomAttributes)
        public virtual System.Nullable<int> РазмерNullableInt
        {
            get
            {
                // *** Start programmer edit section *** (Лапа.РазмерNullableInt Get start)

                // *** End programmer edit section *** (Лапа.РазмерNullableInt Get start)
                System.Nullable<int> result = this.fРазмерNullableInt;
                // *** Start programmer edit section *** (Лапа.РазмерNullableInt Get end)

                // *** End programmer edit section *** (Лапа.РазмерNullableInt Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Лапа.РазмерNullableInt Set start)

                // *** End programmer edit section *** (Лапа.РазмерNullableInt Set start)
                this.fРазмерNullableInt = value;
                // *** Start programmer edit section *** (Лапа.РазмерNullableInt Set end)

                // *** End programmer edit section *** (Лапа.РазмерNullableInt Set end)
            }
        }
        
        /// <summary>
        /// РазмерDecimal.
        /// </summary>
        // *** Start programmer edit section *** (Лапа.РазмерDecimal CustomAttributes)

        // *** End programmer edit section *** (Лапа.РазмерDecimal CustomAttributes)
        public virtual decimal РазмерDecimal
        {
            get
            {
                // *** Start programmer edit section *** (Лапа.РазмерDecimal Get start)

                // *** End programmer edit section *** (Лапа.РазмерDecimal Get start)
                decimal result = this.fРазмерDecimal;
                // *** Start programmer edit section *** (Лапа.РазмерDecimal Get end)

                // *** End programmer edit section *** (Лапа.РазмерDecimal Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Лапа.РазмерDecimal Set start)

                // *** End programmer edit section *** (Лапа.РазмерDecimal Set start)
                this.fРазмерDecimal = value;
                // *** Start programmer edit section *** (Лапа.РазмерDecimal Set end)

                // *** End programmer edit section *** (Лапа.РазмерDecimal Set end)
            }
        }
        
        /// <summary>
        /// РазмерNullableDecimal.
        /// </summary>
        // *** Start programmer edit section *** (Лапа.РазмерNullableDecimal CustomAttributes)

        // *** End programmer edit section *** (Лапа.РазмерNullableDecimal CustomAttributes)
        public virtual System.Nullable<decimal> РазмерNullableDecimal
        {
            get
            {
                // *** Start programmer edit section *** (Лапа.РазмерNullableDecimal Get start)

                // *** End programmer edit section *** (Лапа.РазмерNullableDecimal Get start)
                System.Nullable<decimal> result = this.fРазмерNullableDecimal;
                // *** Start programmer edit section *** (Лапа.РазмерNullableDecimal Get end)

                // *** End programmer edit section *** (Лапа.РазмерNullableDecimal Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Лапа.РазмерNullableDecimal Set start)

                // *** End programmer edit section *** (Лапа.РазмерNullableDecimal Set start)
                this.fРазмерNullableDecimal = value;
                // *** Start programmer edit section *** (Лапа.РазмерNullableDecimal Set end)

                // *** End programmer edit section *** (Лапа.РазмерNullableDecimal Set end)
            }
        }
        
        /// <summary>
        /// РазмерChar.
        /// </summary>
        // *** Start programmer edit section *** (Лапа.РазмерChar CustomAttributes)

        // *** End programmer edit section *** (Лапа.РазмерChar CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        public virtual char РазмерChar
        {
            get
            {
                // *** Start programmer edit section *** (Лапа.РазмерChar Get)

                return ' ';
                // *** End programmer edit section *** (Лапа.РазмерChar Get)
            }
            set
            {
                // *** Start programmer edit section *** (Лапа.РазмерChar Set)

                // *** End programmer edit section *** (Лапа.РазмерChar Set)
            }
        }
        
        /// <summary>
        /// РазмерNullableChar.
        /// </summary>
        // *** Start programmer edit section *** (Лапа.РазмерNullableChar CustomAttributes)

        // *** End programmer edit section *** (Лапа.РазмерNullableChar CustomAttributes)
        public virtual System.Nullable<char> РазмерNullableChar
        {
            get
            {
                // *** Start programmer edit section *** (Лапа.РазмерNullableChar Get start)

                // *** End programmer edit section *** (Лапа.РазмерNullableChar Get start)
                System.Nullable<char> result = this.fРазмерNullableChar;
                // *** Start programmer edit section *** (Лапа.РазмерNullableChar Get end)

                // *** End programmer edit section *** (Лапа.РазмерNullableChar Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Лапа.РазмерNullableChar Set start)

                // *** End programmer edit section *** (Лапа.РазмерNullableChar Set start)
                this.fРазмерNullableChar = value;
                // *** Start programmer edit section *** (Лапа.РазмерNullableChar Set end)

                // *** End programmer edit section *** (Лапа.РазмерNullableChar Set end)
            }
        }
        
        /// <summary>
        /// Лапа.
        /// </summary>
        // *** Start programmer edit section *** (Лапа.ТипЛапы CustomAttributes)

        // *** End programmer edit section *** (Лапа.ТипЛапы CustomAttributes)
        public virtual NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.ТипЛапы ТипЛапы
        {
            get
            {
                // *** Start programmer edit section *** (Лапа.ТипЛапы Get start)

                // *** End programmer edit section *** (Лапа.ТипЛапы Get start)
                NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.ТипЛапы result = this.fТипЛапы;
                // *** Start programmer edit section *** (Лапа.ТипЛапы Get end)

                // *** End programmer edit section *** (Лапа.ТипЛапы Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Лапа.ТипЛапы Set start)

                // *** End programmer edit section *** (Лапа.ТипЛапы Set start)
                this.fТипЛапы = value;
                // *** Start programmer edit section *** (Лапа.ТипЛапы Set end)

                // *** End programmer edit section *** (Лапа.ТипЛапы Set end)
            }
        }
        
        /// <summary>
        /// Лапа.
        /// </summary>
        // *** Start programmer edit section *** (Лапа.Перелом CustomAttributes)

        // *** End programmer edit section *** (Лапа.Перелом CustomAttributes)
        public virtual NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.DetailArrayOfПерелом Перелом
        {
            get
            {
                // *** Start programmer edit section *** (Лапа.Перелом Get start)

                // *** End programmer edit section *** (Лапа.Перелом Get start)
                if ((this.fПерелом == null))
                {
                    this.fПерелом = new NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.DetailArrayOfПерелом(this);
                }
                NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.DetailArrayOfПерелом result = this.fПерелом;
                // *** Start programmer edit section *** (Лапа.Перелом Get end)

                // *** End programmer edit section *** (Лапа.Перелом Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Лапа.Перелом Set start)

                // *** End programmer edit section *** (Лапа.Перелом Set start)
                this.fПерелом = value;
                // *** Start programmer edit section *** (Лапа.Перелом Set end)

                // *** End programmer edit section *** (Лапа.Перелом Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Кошка.
        /// </summary>
        // *** Start programmer edit section *** (Лапа.Кошка CustomAttributes)

        // *** End programmer edit section *** (Лапа.Кошка CustomAttributes)
        [Agregator()]
        [NotNull()]
        public virtual NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Кошка Кошка
        {
            get
            {
                // *** Start programmer edit section *** (Лапа.Кошка Get start)

                // *** End programmer edit section *** (Лапа.Кошка Get start)
                NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Кошка result = this.fКошка;
                // *** Start programmer edit section *** (Лапа.Кошка Get end)

                // *** End programmer edit section *** (Лапа.Кошка Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Лапа.Кошка Set start)

                // *** End programmer edit section *** (Лапа.Кошка Set start)
                this.fКошка = value;
                // *** Start programmer edit section *** (Лапа.Кошка Set end)

                // *** End programmer edit section *** (Лапа.Кошка Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "k_ЛапаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View k_ЛапаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("k_ЛапаE", typeof(NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Лапа));
                }
            }
            
            /// <summary>
            /// "КИЛ_ЛапаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КИЛ_ЛапаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КИЛ_ЛапаE", typeof(NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Лапа));
                }
            }
            
            /// <summary>
            /// "ЛапаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЛапаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЛапаE", typeof(NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Лапа));
                }
            }
            
            /// <summary>
            /// "ЛапаFull" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЛапаFull
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЛапаFull", typeof(NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Лапа));
                }
            }
            
            /// <summary>
            /// "ЛапаShort" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЛапаShort
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЛапаShort", typeof(NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Лапа));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of Лапа.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfЛапа CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfЛапа CustomAttributes)
    public class DetailArrayOfЛапа : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.DetailArrayOfЛапа members)

        // *** End programmer edit section *** (NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.DetailArrayOfЛапа members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type Лапа by index.
        /// </summary>
        /// <summary>
        /// Adds object with type Лапа.
        /// </summary>
        public DetailArrayOfЛапа(NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Кошка fКошка) : 
                base(typeof(Лапа), ((ICSSoft.STORMNET.DataObject)(fКошка)))
        {
        }
        
        public NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Лапа this[int index]
        {
            get
            {
                return ((NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Лапа)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Лапа dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
