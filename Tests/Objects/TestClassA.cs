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
    /// TestClassA.
    /// </summary>
    // *** Start programmer edit section *** (TestClassA CustomAttributes)

    // *** End programmer edit section *** (TestClassA CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class TestClassA : ICSSoft.STORMNET.DataObject
    {
        
        private string fName;
        
        private int fValue;
        
        private NewPlatform.ClickHouseDataService.Tests.МастерМ fМастер;
        
        // *** Start programmer edit section *** (TestClassA CustomMembers)

        // *** End programmer edit section *** (TestClassA CustomMembers)

        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (TestClassA.Name CustomAttributes)

        // *** End programmer edit section *** (TestClassA.Name CustomAttributes)
        [StrLen(255)]
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (TestClassA.Name Get start)

                // *** End programmer edit section *** (TestClassA.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (TestClassA.Name Get end)

                // *** End programmer edit section *** (TestClassA.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TestClassA.Name Set start)

                // *** End programmer edit section *** (TestClassA.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (TestClassA.Name Set end)

                // *** End programmer edit section *** (TestClassA.Name Set end)
            }
        }
        
        /// <summary>
        /// Value.
        /// </summary>
        // *** Start programmer edit section *** (TestClassA.Value CustomAttributes)

        // *** End programmer edit section *** (TestClassA.Value CustomAttributes)
        public virtual int Value
        {
            get
            {
                // *** Start programmer edit section *** (TestClassA.Value Get start)

                // *** End programmer edit section *** (TestClassA.Value Get start)
                int result = this.fValue;
                // *** Start programmer edit section *** (TestClassA.Value Get end)

                // *** End programmer edit section *** (TestClassA.Value Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TestClassA.Value Set start)

                // *** End programmer edit section *** (TestClassA.Value Set start)
                this.fValue = value;
                // *** Start programmer edit section *** (TestClassA.Value Set end)

                // *** End programmer edit section *** (TestClassA.Value Set end)
            }
        }
        
        /// <summary>
        /// TestClassA.
        /// </summary>
        // *** Start programmer edit section *** (TestClassA.Мастер CustomAttributes)

        // *** End programmer edit section *** (TestClassA.Мастер CustomAttributes)
        [PropertyStorage("Мастер")]
        [TypeUsage(new string[] {
                "NewPlatform.ClickHouseDataService.Tests.МастерМ",
                "NewPlatform.ClickHouseDataService.Tests.НаследникМ1",
                "NewPlatform.ClickHouseDataService.Tests.НаследникМ2"})]
        [NotNull()]
        public virtual NewPlatform.ClickHouseDataService.Tests.МастерМ Мастер
        {
            get
            {
                // *** Start programmer edit section *** (TestClassA.Мастер Get start)

                // *** End programmer edit section *** (TestClassA.Мастер Get start)
                NewPlatform.ClickHouseDataService.Tests.МастерМ result = this.fМастер;
                // *** Start programmer edit section *** (TestClassA.Мастер Get end)

                // *** End programmer edit section *** (TestClassA.Мастер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TestClassA.Мастер Set start)

                // *** End programmer edit section *** (TestClassA.Мастер Set start)
                this.fМастер = value;
                // *** Start programmer edit section *** (TestClassA.Мастер Set end)

                // *** End programmer edit section *** (TestClassA.Мастер Set end)
            }
        }
    }
}
