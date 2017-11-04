using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iatacodes.Models
{
    public class AirPortResponse
    {



        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class root
        {

            private string requestField;

            private rootResponse[] responseField;

            /// <remarks/>
            public string request
            {
                get
                {
                    return this.requestField;
                }
                set
                {
                    this.requestField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("response", IsNullable = false)]
            public rootResponse[] response
            {
                get
                {
                    return this.responseField;
                }
                set
                {
                    this.responseField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class rootResponse
        {

            private string codeField;

            private string nameField;

            private string[] textField;

            /// <remarks/>
            public string code
            {
                get
                {
                    return this.codeField;
                }
                set
                {
                    this.codeField = value;
                }
            }

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }



    }
}
