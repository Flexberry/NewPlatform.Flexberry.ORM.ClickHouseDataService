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
    /// Выплаты.
    /// </summary>
    // *** Start programmer edit section *** (Выплаты CustomAttributes)

    // *** End programmer edit section *** (Выплаты CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ВыплатыViewE", new string[] {
            "ДатаВыплаты as \'Дата выплаты\'",
            "СуммаВыплаты as \'Сумма выплаты\'"})]
    [View("ВыплатыViewL", new string[] {
            "ДатаВыплаты as \'Дата выплаты\'",
            "СуммаВыплаты as \'Сумма выплаты\'"})]
    public class Выплаты : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДатаВыплаты;
        
        private double fСуммаВыплаты;
        
        private NewPlatform.ClickHouseDataService.Tests.Кредит fКредит1;
        
        // *** Start programmer edit section *** (Выплаты CustomMembers)

        // *** End programmer edit section *** (Выплаты CustomMembers)

        
        /// <summary>
        /// ДатаВыплаты.
        /// </summary>
        // *** Start programmer edit section *** (Выплаты.ДатаВыплаты CustomAttributes)

        // *** End programmer edit section *** (Выплаты.ДатаВыплаты CustomAttributes)
        public virtual System.DateTime ДатаВыплаты
        {
            get
            {
                // *** Start programmer edit section *** (Выплаты.ДатаВыплаты Get start)

                // *** End programmer edit section *** (Выплаты.ДатаВыплаты Get start)
                System.DateTime result = this.fДатаВыплаты;
                // *** Start programmer edit section *** (Выплаты.ДатаВыплаты Get end)

                // *** End programmer edit section *** (Выплаты.ДатаВыплаты Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Выплаты.ДатаВыплаты Set start)

                // *** End programmer edit section *** (Выплаты.ДатаВыплаты Set start)
                this.fДатаВыплаты = value;
                // *** Start programmer edit section *** (Выплаты.ДатаВыплаты Set end)

                // *** End programmer edit section *** (Выплаты.ДатаВыплаты Set end)
            }
        }
        
        /// <summary>
        /// СуммаВыплаты.
        /// </summary>
        // *** Start programmer edit section *** (Выплаты.СуммаВыплаты CustomAttributes)

        // *** End programmer edit section *** (Выплаты.СуммаВыплаты CustomAttributes)
        public virtual double СуммаВыплаты
        {
            get
            {
                // *** Start programmer edit section *** (Выплаты.СуммаВыплаты Get start)

                // *** End programmer edit section *** (Выплаты.СуммаВыплаты Get start)
                double result = this.fСуммаВыплаты;
                // *** Start programmer edit section *** (Выплаты.СуммаВыплаты Get end)

                // *** End programmer edit section *** (Выплаты.СуммаВыплаты Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Выплаты.СуммаВыплаты Set start)

                // *** End programmer edit section *** (Выплаты.СуммаВыплаты Set start)
                this.fСуммаВыплаты = value;
                // *** Start programmer edit section *** (Выплаты.СуммаВыплаты Set end)

                // *** End programmer edit section *** (Выплаты.СуммаВыплаты Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку NewPlatform.ClickHouseDataService.Tests.Кредит.
        /// </summary>
        // *** Start programmer edit section *** (Выплаты.Кредит1 CustomAttributes)

        // *** End programmer edit section *** (Выплаты.Кредит1 CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Кредит1"})]
        public virtual NewPlatform.ClickHouseDataService.Tests.Кредит Кредит1
        {
            get
            {
                // *** Start programmer edit section *** (Выплаты.Кредит1 Get start)

                // *** End programmer edit section *** (Выплаты.Кредит1 Get start)
                NewPlatform.ClickHouseDataService.Tests.Кредит result = this.fКредит1;
                // *** Start programmer edit section *** (Выплаты.Кредит1 Get end)

                // *** End programmer edit section *** (Выплаты.Кредит1 Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Выплаты.Кредит1 Set start)

                // *** End programmer edit section *** (Выплаты.Кредит1 Set start)
                this.fКредит1 = value;
                // *** Start programmer edit section *** (Выплаты.Кредит1 Set end)

                // *** End programmer edit section *** (Выплаты.Кредит1 Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ВыплатыViewE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ВыплатыViewE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ВыплатыViewE", typeof(NewPlatform.ClickHouseDataService.Tests.Выплаты));
                }
            }
            
            /// <summary>
            /// "ВыплатыViewL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ВыплатыViewL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ВыплатыViewL", typeof(NewPlatform.ClickHouseDataService.Tests.Выплаты));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of Выплаты.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfВыплаты CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfВыплаты CustomAttributes)
    public class DetailArrayOfВыплаты : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (NewPlatform.ClickHouseDataService.Tests.DetailArrayOfВыплаты members)

        // *** End programmer edit section *** (NewPlatform.ClickHouseDataService.Tests.DetailArrayOfВыплаты members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type Выплаты by index.
        /// </summary>
        /// <summary>
        /// Adds object with type Выплаты.
        /// </summary>
        public DetailArrayOfВыплаты(NewPlatform.ClickHouseDataService.Tests.Кредит fКредит) : 
                base(typeof(Выплаты), ((ICSSoft.STORMNET.DataObject)(fКредит)))
        {
        }
        
        public NewPlatform.ClickHouseDataService.Tests.Выплаты this[int index]
        {
            get
            {
                return ((NewPlatform.ClickHouseDataService.Tests.Выплаты)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(NewPlatform.ClickHouseDataService.Tests.Выплаты dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
