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
    /// Country2.
    /// </summary>
    // *** Start programmer edit section *** (Country2 CustomAttributes)

    // *** End programmer edit section *** (Country2 CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("Country2E", new string[] {
            "CountryName as \'Country name\'",
            "XCoordinate as \'X coordinate\'",
            "YCoordinate as \'Y coordinate\'"})]
    [AssociatedDetailViewAttribute("Country2E", "Region", "RegionE", true, "", "Region", true, new string[] {
            ""})]
    [View("Country2L", new string[] {
            "CountryName as \'Country name\'",
            "XCoordinate as \'X coordinate\'",
            "YCoordinate as \'Y coordinate\'"})]
    public class Country2 : NewPlatform.ClickHouseDataService.Tests.Territory2
    {
        
        private string fCountryName;
        
        private NewPlatform.ClickHouseDataService.Tests.DetailArrayOfRegion fRegion;
        
        // *** Start programmer edit section *** (Country2 CustomMembers)

        // *** End programmer edit section *** (Country2 CustomMembers)

        
        /// <summary>
        /// CountryName.
        /// </summary>
        // *** Start programmer edit section *** (Country2.CountryName CustomAttributes)

        // *** End programmer edit section *** (Country2.CountryName CustomAttributes)
        [StrLen(255)]
        public virtual string CountryName
        {
            get
            {
                // *** Start programmer edit section *** (Country2.CountryName Get start)

                // *** End programmer edit section *** (Country2.CountryName Get start)
                string result = this.fCountryName;
                // *** Start programmer edit section *** (Country2.CountryName Get end)

                // *** End programmer edit section *** (Country2.CountryName Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Country2.CountryName Set start)

                // *** End programmer edit section *** (Country2.CountryName Set start)
                this.fCountryName = value;
                // *** Start programmer edit section *** (Country2.CountryName Set end)

                // *** End programmer edit section *** (Country2.CountryName Set end)
            }
        }
        
        /// <summary>
        /// Country2.
        /// </summary>
        // *** Start programmer edit section *** (Country2.Region CustomAttributes)

        // *** End programmer edit section *** (Country2.Region CustomAttributes)
        public virtual NewPlatform.ClickHouseDataService.Tests.DetailArrayOfRegion Region
        {
            get
            {
                // *** Start programmer edit section *** (Country2.Region Get start)

                // *** End programmer edit section *** (Country2.Region Get start)
                if ((this.fRegion == null))
                {
                    this.fRegion = new NewPlatform.ClickHouseDataService.Tests.DetailArrayOfRegion(this);
                }
                NewPlatform.ClickHouseDataService.Tests.DetailArrayOfRegion result = this.fRegion;
                // *** Start programmer edit section *** (Country2.Region Get end)

                // *** End programmer edit section *** (Country2.Region Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Country2.Region Set start)

                // *** End programmer edit section *** (Country2.Region Set start)
                this.fRegion = value;
                // *** Start programmer edit section *** (Country2.Region Set end)

                // *** End programmer edit section *** (Country2.Region Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "Country2E" view.
            /// </summary>
            public static ICSSoft.STORMNET.View Country2E
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("Country2E", typeof(NewPlatform.ClickHouseDataService.Tests.Country2));
                }
            }
            
            /// <summary>
            /// "Country2L" view.
            /// </summary>
            public static ICSSoft.STORMNET.View Country2L
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("Country2L", typeof(NewPlatform.ClickHouseDataService.Tests.Country2));
                }
            }
        }
    }
}