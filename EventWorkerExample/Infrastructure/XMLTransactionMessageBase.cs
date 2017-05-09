using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EventWorkerExample.Infrastructure {
    public abstract class XMLTransactionMessageBase<T> where T : class {
        protected XMLTransactionMessageBase() {
            Annouce();
        }


        public static T CreateInstance(string xml) {
            return SingletonFactory.Instance.ExtXmlDeSerialize(xml);
        }

        public static T CreateInstance() {
            return SingletonFactory.Instance;
        }

        public override string ToString() {
            return this.ExtXmlSerialize();
        }

        private void Annouce() {
            Console.WriteLine(string.Format("Instance of type: {0} has been created", typeof(T).Name));
        }

        class SingletonFactory {
            static SingletonFactory() { }

            SingletonFactory() { }

            internal static readonly T Instance = GetInstance();

            static T GetInstance() {
                var theType = typeof(T);

                T inst;

                try {
                    inst = (T)theType
                        .InvokeMember(theType.Name,
                        BindingFlags.CreateInstance | BindingFlags.Instance
                        | BindingFlags.NonPublic,
                        null, null, null,
                        CultureInfo.InvariantCulture);
                } catch (MissingMethodException ex) {
                    throw new TypeLoadException(string.Format(
                        CultureInfo.CurrentCulture,
                        "The type '{0}' must have a private constructor to be used with this pattern.", theType.FullName)
                        , ex);
                }

                return inst;
            }
        }



    }
}
