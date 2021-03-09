﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.ClickHouseDataService.Tests
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Кредит.
    /// </summary>
    // *** Start programmer edit section *** (Кредит CustomAttributes)

    // *** End programmer edit section *** (Кредит CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("C__КредитE", new string[] {
            "ДатаВыдачи as \'Дата выдачи\'",
            "СуммаКредита as \'СуммаДляCaptionКредита\'",
            "СрокКредита as \'Срок кредита\'",
            "Клиент as \'Клиент\'",
            "Клиент.ФИО as \'ФИО\'",
            "Клиент.Прописка as \'Прописка\'",
            "ИнспекторПоКредиту as \'Инспектор по кредиту\'",
            "ИнспекторПоКредиту.ФИО as \'ФИО\'"})]
    [AssociatedDetailViewAttribute("C__КредитE", "Выплаты", "ВыплатыViewE", true, "", "", true, new string[] {
            ""})]
    [View("КредитViewE", new string[] {
            "ДатаВыдачи as \'Дата выдачи\'",
            "СуммаКредита as \'Сумма кредита\'",
            "СрокКредита as \'Срок кредита\'",
            "ВидКредита as \'Вид кредита\'",
            "Клиент as \'Клиент.ФИО\'",
            "ИнспекторПоКредиту as \'ИнспекторПоКредиту.ФИО\'"})]
    [AssociatedDetailViewAttribute("КредитViewE", "Выплаты", "ВыплатыViewE", true, "", "ВыплатыViewE", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("КредитViewE", "Клиент", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "ФИО")]
    [MasterViewDefineAttribute("КредитViewE", "ИнспекторПоКредиту", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "ФИО")]
    [View("КредитViewL", new string[] {
            "ДатаВыдачи as \'Дата выдачи\'",
            "СуммаКредита as \'Сумма кредита\'",
            "СрокКредита as \'Срок кредита\'",
            "ВидКредита as \'Вид кредита\'",
            "Клиент.ФИО as \'Клиент.ФИО\'",
            "ИнспекторПоКредиту.ФИО as \'ИнспекторПоКредиту.ФИО\'"})]
    [MasterViewDefineAttribute("КредитViewL", "Клиент.ФИО", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "")]
    [MasterViewDefineAttribute("КредитViewL", "ИнспекторПоКредиту.ФИО", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "")]
    public class Кредит : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДатаВыдачи;
        
        private double fСуммаКредита;
        
        private int fСрокКредита;
        
        private NewPlatform.ClickHouseDataService.Tests.ВидКредита fВидКредита;
        
        private NewPlatform.ClickHouseDataService.Tests.Клиент fКлиент;
        
        private NewPlatform.ClickHouseDataService.Tests.ИнспекторПоКредиту fИнспекторПоКредиту;
        
        private NewPlatform.ClickHouseDataService.Tests.DetailArrayOfВыплаты fВыплаты;
        
        // *** Start programmer edit section *** (Кредит CustomMembers)

        // *** End programmer edit section *** (Кредит CustomMembers)

        
        /// <summary>
        /// ДатаВыдачи.
        /// </summary>
        // *** Start programmer edit section *** (Кредит.ДатаВыдачи CustomAttributes)

        // *** End programmer edit section *** (Кредит.ДатаВыдачи CustomAttributes)
        public virtual System.DateTime ДатаВыдачи
        {
            get
            {
                // *** Start programmer edit section *** (Кредит.ДатаВыдачи Get start)

                // *** End programmer edit section *** (Кредит.ДатаВыдачи Get start)
                System.DateTime result = this.fДатаВыдачи;
                // *** Start programmer edit section *** (Кредит.ДатаВыдачи Get end)

                // *** End programmer edit section *** (Кредит.ДатаВыдачи Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Кредит.ДатаВыдачи Set start)

                // *** End programmer edit section *** (Кредит.ДатаВыдачи Set start)
                this.fДатаВыдачи = value;
                // *** Start programmer edit section *** (Кредит.ДатаВыдачи Set end)

                // *** End programmer edit section *** (Кредит.ДатаВыдачи Set end)
            }
        }
        
        /// <summary>
        /// СуммаКредита.
        /// </summary>
        // *** Start programmer edit section *** (Кредит.СуммаКредита CustomAttributes)

        // *** End programmer edit section *** (Кредит.СуммаКредита CustomAttributes)
        public virtual double СуммаКредита
        {
            get
            {
                // *** Start programmer edit section *** (Кредит.СуммаКредита Get start)

                // *** End programmer edit section *** (Кредит.СуммаКредита Get start)
                double result = this.fСуммаКредита;
                // *** Start programmer edit section *** (Кредит.СуммаКредита Get end)

                // *** End programmer edit section *** (Кредит.СуммаКредита Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Кредит.СуммаКредита Set start)

                // *** End programmer edit section *** (Кредит.СуммаКредита Set start)
                this.fСуммаКредита = value;
                // *** Start programmer edit section *** (Кредит.СуммаКредита Set end)

                // *** End programmer edit section *** (Кредит.СуммаКредита Set end)
            }
        }
        
        /// <summary>
        /// СрокКредита.
        /// </summary>
        // *** Start programmer edit section *** (Кредит.СрокКредита CustomAttributes)

        // *** End programmer edit section *** (Кредит.СрокКредита CustomAttributes)
        public virtual int СрокКредита
        {
            get
            {
                // *** Start programmer edit section *** (Кредит.СрокКредита Get start)

                // *** End programmer edit section *** (Кредит.СрокКредита Get start)
                int result = this.fСрокКредита;
                // *** Start programmer edit section *** (Кредит.СрокКредита Get end)

                // *** End programmer edit section *** (Кредит.СрокКредита Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Кредит.СрокКредита Set start)

                // *** End programmer edit section *** (Кредит.СрокКредита Set start)
                this.fСрокКредита = value;
                // *** Start programmer edit section *** (Кредит.СрокКредита Set end)

                // *** End programmer edit section *** (Кредит.СрокКредита Set end)
            }
        }
        
        /// <summary>
        /// ВидКредита.
        /// </summary>
        // *** Start programmer edit section *** (Кредит.ВидКредита CustomAttributes)

        // *** End programmer edit section *** (Кредит.ВидКредита CustomAttributes)
        public virtual NewPlatform.ClickHouseDataService.Tests.ВидКредита ВидКредита
        {
            get
            {
                // *** Start programmer edit section *** (Кредит.ВидКредита Get start)

                // *** End programmer edit section *** (Кредит.ВидКредита Get start)
                NewPlatform.ClickHouseDataService.Tests.ВидКредита result = this.fВидКредита;
                // *** Start programmer edit section *** (Кредит.ВидКредита Get end)

                // *** End programmer edit section *** (Кредит.ВидКредита Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Кредит.ВидКредита Set start)

                // *** End programmer edit section *** (Кредит.ВидКредита Set start)
                this.fВидКредита = value;
                // *** Start programmer edit section *** (Кредит.ВидКредита Set end)

                // *** End programmer edit section *** (Кредит.ВидКредита Set end)
            }
        }
        
        /// <summary>
        /// Кредит.
        /// </summary>
        // *** Start programmer edit section *** (Кредит.Клиент CustomAttributes)

        // *** End programmer edit section *** (Кредит.Клиент CustomAttributes)
        [PropertyStorage(new string[] {
                "Клиент"})]
        public virtual NewPlatform.ClickHouseDataService.Tests.Клиент Клиент
        {
            get
            {
                // *** Start programmer edit section *** (Кредит.Клиент Get start)

                // *** End programmer edit section *** (Кредит.Клиент Get start)
                NewPlatform.ClickHouseDataService.Tests.Клиент result = this.fКлиент;
                // *** Start programmer edit section *** (Кредит.Клиент Get end)

                // *** End programmer edit section *** (Кредит.Клиент Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Кредит.Клиент Set start)

                // *** End programmer edit section *** (Кредит.Клиент Set start)
                this.fКлиент = value;
                // *** Start programmer edit section *** (Кредит.Клиент Set end)

                // *** End programmer edit section *** (Кредит.Клиент Set end)
            }
        }
        
        /// <summary>
        /// Кредит.
        /// </summary>
        // *** Start programmer edit section *** (Кредит.ИнспекторПоКредиту CustomAttributes)

        // *** End programmer edit section *** (Кредит.ИнспекторПоКредиту CustomAttributes)
        [PropertyStorage(new string[] {
                "ИнспекторПоКред"})]
        public virtual NewPlatform.ClickHouseDataService.Tests.ИнспекторПоКредиту ИнспекторПоКредиту
        {
            get
            {
                // *** Start programmer edit section *** (Кредит.ИнспекторПоКредиту Get start)

                // *** End programmer edit section *** (Кредит.ИнспекторПоКредиту Get start)
                NewPlatform.ClickHouseDataService.Tests.ИнспекторПоКредиту result = this.fИнспекторПоКредиту;
                // *** Start programmer edit section *** (Кредит.ИнспекторПоКредиту Get end)

                // *** End programmer edit section *** (Кредит.ИнспекторПоКредиту Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Кредит.ИнспекторПоКредиту Set start)

                // *** End programmer edit section *** (Кредит.ИнспекторПоКредиту Set start)
                this.fИнспекторПоКредиту = value;
                // *** Start programmer edit section *** (Кредит.ИнспекторПоКредиту Set end)

                // *** End programmer edit section *** (Кредит.ИнспекторПоКредиту Set end)
            }
        }
        
        /// <summary>
        /// Кредит.
        /// </summary>
        // *** Start programmer edit section *** (Кредит.Выплаты CustomAttributes)

        // *** End programmer edit section *** (Кредит.Выплаты CustomAttributes)
        public virtual NewPlatform.ClickHouseDataService.Tests.DetailArrayOfВыплаты Выплаты
        {
            get
            {
                // *** Start programmer edit section *** (Кредит.Выплаты Get start)

                // *** End programmer edit section *** (Кредит.Выплаты Get start)
                if ((this.fВыплаты == null))
                {
                    this.fВыплаты = new NewPlatform.ClickHouseDataService.Tests.DetailArrayOfВыплаты(this);
                }
                NewPlatform.ClickHouseDataService.Tests.DetailArrayOfВыплаты result = this.fВыплаты;
                // *** Start programmer edit section *** (Кредит.Выплаты Get end)

                // *** End programmer edit section *** (Кредит.Выплаты Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Кредит.Выплаты Set start)

                // *** End programmer edit section *** (Кредит.Выплаты Set start)
                this.fВыплаты = value;
                // *** Start programmer edit section *** (Кредит.Выплаты Set end)

                // *** End programmer edit section *** (Кредит.Выплаты Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "C__КредитE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View C__КредитE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("C__КредитE", typeof(NewPlatform.ClickHouseDataService.Tests.Кредит));
                }
            }
            
            /// <summary>
            /// "КредитViewE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КредитViewE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КредитViewE", typeof(NewPlatform.ClickHouseDataService.Tests.Кредит));
                }
            }
            
            /// <summary>
            /// "КредитViewL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КредитViewL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КредитViewL", typeof(NewPlatform.ClickHouseDataService.Tests.Кредит));
                }
            }
        }
    }
}
