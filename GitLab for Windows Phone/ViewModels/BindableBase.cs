using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GitLab_for_Windows_Phone.ViewModels
{
    public class BindableBase : INotifyPropertyChanged
    {
        [JsonIgnore]
        public SynchronizationContext Context { get; set; }

        protected bool _processing;

        [JsonIgnore]
        public bool Processing
        {
            get { return _processing; }
            set { SetValue(ref _processing, value); }
        }

        public BindableBase()
        {
            Context = SynchronizationContext.Current;
        }

        #region INotifyPropertyChanged Membres

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Set the value of the given property and generates the PropertyChanged event.
        /// </summary>
        /// <typeparam name="T">The type of the property</typeparam>
        /// <param name="property">The reference to the property</param>
        /// <param name="value">The value to set</param>
        /// <param name="propertyName">The name of the property</param>
        protected bool SetValue<T>(ref T property, T value, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(property, value))
            {
                return false;
            }

            property = value;
            NotifyPropertyChanged(propertyName);

            return true;
        }

        #endregion

        public void NotifyPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                if (Context != null)
                {
                    Context.Post(s => handler(this, new PropertyChangedEventArgs(propertyName)), null);
                }
                else
                {
                    handler(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }
    }
}
