using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventWorkerExample {
    public class TestTransactionDataModel {
        public int ID { get; set; }
        public string Message { get; set; }
        public bool IsProcessed { get; set; }
    }

    public class TestTransactionData {

        private static TestTransactionData instance;
        public static TestTransactionData Instance {
            get {
                if(instance == null) {
                    instance = new TestTransactionData();
                }
                return instance;
            }
        }

        private List<TestTransactionDataModel> data;
        public List<TestTransactionDataModel> Data {
            get { return data; }
            set { data = value; }
        }


        private TestTransactionData() {
            data = new List<TestTransactionDataModel>();
            CreateTestData();
        }

        private void CreateTestData() {


            data.Add(new TestTransactionDataModel { ID = 1, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>1</ID><Message>a</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 2, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>2</ID><Message>b</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 3, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>3</ID><Message>c</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 4, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>4</ID><Message>d</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 5, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>5</ID><Message>e</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 6, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>6</ID><Message>f</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 7, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>7</ID><Message>g</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 8, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>8</ID><Message>h</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 9, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>9</ID><Message>i</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 10, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>10</ID><Message>j</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 11, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>11</ID><Message>k</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 12, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>12</ID><Message>l</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 13, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>13</ID><Message>m</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 14, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>14</ID><Message>n</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 15, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>15</ID><Message>o</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 16, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>16</ID><Message>p</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 17, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>17</ID><Message>q</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 18, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>18</ID><Message>r</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 19, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>19</ID><Message>s</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 20, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>20</ID><Message>t</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 21, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>21</ID><Message>u</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 22, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>22</ID><Message>v</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 23, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>23</ID><Message>w</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 24, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>24</ID><Message>x</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 25, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>25</ID><Message>y</Message></TestTransaction>", IsProcessed = false });
            data.Add(new TestTransactionDataModel { ID = 26, Message = @"<?xml version=""1.0"" encoding=""utf-16""?><TestTransaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><ID>26</ID><Message>z</Message></TestTransaction>", IsProcessed = false });






        }


    }


}
