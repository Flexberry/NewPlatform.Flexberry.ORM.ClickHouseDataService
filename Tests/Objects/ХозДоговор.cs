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
    /// ХозДоговор.
    /// </summary>
    // *** Start programmer edit section *** (ХозДоговор CustomAttributes)

    // *** End programmer edit section *** (ХозДоговор CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ХозДоговорE", new string[] {
            "НомерХозДоговора"})]
    [AssociatedDetailViewAttribute("ХозДоговорE", "ИФХозДоговора", "ИФХозДоговораE", true, "", "", true, new string[] {
            ""})]
    [AssociatedDetailViewAttribute("ХозДоговорE", "УчастникХозДоговора", "УчастникХозДоговораE", true, "", "", true, new string[] {
            ""})]
    [View("ХозДоговорL", new string[] {
            "НомерХозДоговора"})]
    public class ХозДоговор : ICSSoft.STORMNET.DataObject
    {
        
        private int fНомерХозДоговора;
        
        private NewPlatform.ClickHouseDataService.Tests.DetailArrayOfУчастникХозДоговора fУчастникХозДоговора;
        
        private NewPlatform.ClickHouseDataService.Tests.DetailArrayOfИФХозДоговора fИФХозДоговора;
        
        // *** Start programmer edit section *** (ХозДоговор CustomMembers)

        // *** End programmer edit section *** (ХозДоговор CustomMembers)

        
        /// <summary>
        /// НомерХозДоговора.
        /// </summary>
        // *** Start programmer edit section *** (ХозДоговор.НомерХозДоговора CustomAttributes)

        // *** End programmer edit section *** (ХозДоговор.НомерХозДоговора CustomAttributes)
        [PropertyStorage("НомХозДоговора")]
        public virtual int НомерХозДоговора
        {
            get
            {
                // *** Start programmer edit section *** (ХозДоговор.НомерХозДоговора Get start)

                // *** End programmer edit section *** (ХозДоговор.НомерХозДоговора Get start)
                int result = this.fНомерХозДоговора;
                // *** Start programmer edit section *** (ХозДоговор.НомерХозДоговора Get end)

                // *** End programmer edit section *** (ХозДоговор.НомерХозДоговора Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ХозДоговор.НомерХозДоговора Set start)

                // *** End programmer edit section *** (ХозДоговор.НомерХозДоговора Set start)
                this.fНомерХозДоговора = value;
                // *** Start programmer edit section *** (ХозДоговор.НомерХозДоговора Set end)

                // *** End programmer edit section *** (ХозДоговор.НомерХозДоговора Set end)
            }
        }
        
        /// <summary>
        /// ХозДоговор.
        /// </summary>
        // *** Start programmer edit section *** (ХозДоговор.УчастникХозДоговора CustomAttributes)

        // *** End programmer edit section *** (ХозДоговор.УчастникХозДоговора CustomAttributes)
        public virtual NewPlatform.ClickHouseDataService.Tests.DetailArrayOfУчастникХозДоговора УчастникХозДоговора
        {
            get
            {
                // *** Start programmer edit section *** (ХозДоговор.УчастникХозДоговора Get start)

                // *** End programmer edit section *** (ХозДоговор.УчастникХозДоговора Get start)
                if ((this.fУчастникХозДоговора == null))
                {
                    this.fУчастникХозДоговора = new NewPlatform.ClickHouseDataService.Tests.DetailArrayOfУчастникХозДоговора(this);
                }
                NewPlatform.ClickHouseDataService.Tests.DetailArrayOfУчастникХозДоговора result = this.fУчастникХозДоговора;
                // *** Start programmer edit section *** (ХозДоговор.УчастникХозДоговора Get end)

                // *** End programmer edit section *** (ХозДоговор.УчастникХозДоговора Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ХозДоговор.УчастникХозДоговора Set start)

                // *** End programmer edit section *** (ХозДоговор.УчастникХозДоговора Set start)
                this.fУчастникХозДоговора = value;
                // *** Start programmer edit section *** (ХозДоговор.УчастникХозДоговора Set end)

                // *** End programmer edit section *** (ХозДоговор.УчастникХозДоговора Set end)
            }
        }
        
        /// <summary>
        /// ХозДоговор.
        /// </summary>
        // *** Start programmer edit section *** (ХозДоговор.ИФХозДоговора CustomAttributes)

        // *** End programmer edit section *** (ХозДоговор.ИФХозДоговора CustomAttributes)
        public virtual NewPlatform.ClickHouseDataService.Tests.DetailArrayOfИФХозДоговора ИФХозДоговора
        {
            get
            {
                // *** Start programmer edit section *** (ХозДоговор.ИФХозДоговора Get start)

                // *** End programmer edit section *** (ХозДоговор.ИФХозДоговора Get start)
                if ((this.fИФХозДоговора == null))
                {
                    this.fИФХозДоговора = new NewPlatform.ClickHouseDataService.Tests.DetailArrayOfИФХозДоговора(this);
                }
                NewPlatform.ClickHouseDataService.Tests.DetailArrayOfИФХозДоговора result = this.fИФХозДоговора;
                // *** Start programmer edit section *** (ХозДоговор.ИФХозДоговора Get end)

                // *** End programmer edit section *** (ХозДоговор.ИФХозДоговора Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ХозДоговор.ИФХозДоговора Set start)

                // *** End programmer edit section *** (ХозДоговор.ИФХозДоговора Set start)
                this.fИФХозДоговора = value;
                // *** Start programmer edit section *** (ХозДоговор.ИФХозДоговора Set end)

                // *** End programmer edit section *** (ХозДоговор.ИФХозДоговора Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ХозДоговорE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ХозДоговорE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ХозДоговорE", typeof(NewPlatform.ClickHouseDataService.Tests.ХозДоговор));
                }
            }
            
            /// <summary>
            /// "ХозДоговорL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ХозДоговорL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ХозДоговорL", typeof(NewPlatform.ClickHouseDataService.Tests.ХозДоговор));
                }
            }
        }
    }
}
