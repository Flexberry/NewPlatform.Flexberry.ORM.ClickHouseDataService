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
    /// Dog.
    /// </summary>
    // *** Start programmer edit section *** (Dog CustomAttributes)

    // *** End programmer edit section *** (Dog CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class Dog : ICSSoft.STORMNET.DataObject
    {
        
        private string fName;
        
        private System.DateTime fBirthday;
        
        private bool fAngry;
        
        private NewPlatform.ClickHouseDataService.Tests.Dog fMainDog;
        
        // *** Start programmer edit section *** (Dog CustomMembers)

        // *** End programmer edit section *** (Dog CustomMembers)

        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (Dog.Name CustomAttributes)

        // *** End programmer edit section *** (Dog.Name CustomAttributes)
        [StrLen(255)]
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (Dog.Name Get start)

                // *** End programmer edit section *** (Dog.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (Dog.Name Get end)

                // *** End programmer edit section *** (Dog.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Dog.Name Set start)

                // *** End programmer edit section *** (Dog.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (Dog.Name Set end)

                // *** End programmer edit section *** (Dog.Name Set end)
            }
        }
        
        /// <summary>
        /// Birthday.
        /// </summary>
        // *** Start programmer edit section *** (Dog.Birthday CustomAttributes)

        // *** End programmer edit section *** (Dog.Birthday CustomAttributes)
        public virtual System.DateTime Birthday
        {
            get
            {
                // *** Start programmer edit section *** (Dog.Birthday Get start)

                // *** End programmer edit section *** (Dog.Birthday Get start)
                System.DateTime result = this.fBirthday;
                // *** Start programmer edit section *** (Dog.Birthday Get end)

                // *** End programmer edit section *** (Dog.Birthday Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Dog.Birthday Set start)

                // *** End programmer edit section *** (Dog.Birthday Set start)
                this.fBirthday = value;
                // *** Start programmer edit section *** (Dog.Birthday Set end)

                // *** End programmer edit section *** (Dog.Birthday Set end)
            }
        }
        
        /// <summary>
        /// Angry.
        /// </summary>
        // *** Start programmer edit section *** (Dog.Angry CustomAttributes)

        // *** End programmer edit section *** (Dog.Angry CustomAttributes)
        public virtual bool Angry
        {
            get
            {
                // *** Start programmer edit section *** (Dog.Angry Get start)

                // *** End programmer edit section *** (Dog.Angry Get start)
                bool result = this.fAngry;
                // *** Start programmer edit section *** (Dog.Angry Get end)

                // *** End programmer edit section *** (Dog.Angry Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Dog.Angry Set start)

                // *** End programmer edit section *** (Dog.Angry Set start)
                this.fAngry = value;
                // *** Start programmer edit section *** (Dog.Angry Set end)

                // *** End programmer edit section *** (Dog.Angry Set end)
            }
        }
        
        /// <summary>
        /// Dog.
        /// </summary>
        // *** Start programmer edit section *** (Dog.MainDog CustomAttributes)

        // *** End programmer edit section *** (Dog.MainDog CustomAttributes)
        [PropertyStorage(new string[] {
                "MainDog"})]
        public virtual NewPlatform.ClickHouseDataService.Tests.Dog MainDog
        {
            get
            {
                // *** Start programmer edit section *** (Dog.MainDog Get start)

                // *** End programmer edit section *** (Dog.MainDog Get start)
                NewPlatform.ClickHouseDataService.Tests.Dog result = this.fMainDog;
                // *** Start programmer edit section *** (Dog.MainDog Get end)

                // *** End programmer edit section *** (Dog.MainDog Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Dog.MainDog Set start)

                // *** End programmer edit section *** (Dog.MainDog Set start)
                this.fMainDog = value;
                // *** Start programmer edit section *** (Dog.MainDog Set end)

                // *** End programmer edit section *** (Dog.MainDog Set end)
            }
        }
    }
}