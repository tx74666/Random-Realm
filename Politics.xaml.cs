using System.Windows;
using System.Windows.Controls;

namespace Product1
{
    /// <summary>
    /// Politics.xaml 的交互逻辑
    /// </summary>
    public partial class Politics : Window
    {
        public Politics()
        {
            InitializeComponent();
        }

        private void USA_Click(object sender, RoutedEventArgs e)
        {
            TextBlock text = new()
            {
                // 设置文本块的内容为美国政府体系的信息
                Text = "美国政府体系概述：\n\n" +
                                "1. 联邦政府：\n   - 行政、立法、司法三权分立\n   - 总统、国会、最高法院等机构\n\n" +
                                "2. 各州政府：\n   - 各州独立的政府体系，类似于联邦政府结构\n\n" +
                                "3. 选举制度：\n   - 总统、国会议员等通过选举产生\n\n" +
                                "4. 宪法：\n   - 美国宪法为最高法律文书\n\n" +
                                "5. 分权制衡：\n   - 政府权力分散，相互制约\n\n" +
                                "6. 地方政府：\n   - 县、市政府管理本地事务"
            };

            // 创建一个弹窗并将文本块添加到弹窗中
            MessageBox.Show(text.Text, "美国政府体系");
        }

        private void China_Click(object sender, RoutedEventArgs e)
        {
            TextBlock text = new()
            {
                // 设置文本块的内容为美国政府体系的信息
                Text = "中国政府体系概述：\n\n" +
                                 "1. 单一党制：\n   - 中国共产党（中共）是唯一合法执政党\n   - 中共在政府和社会各个层面发挥主导作用\n\n" +
                                 "2. 国家机关：\n   - 国家主席、国务院（中央政府）、全国人民代表大会等机构\n\n" +
                                 "3. 地方政府：\n   - 省、自治区、直辖市等地方政府层级\n   - 各级地方政府设有人民代表大会和人民政府\n\n" +
                                 "4. 一党领导：\n   - 中共通过中央委员会、政治局等机构进行领导\n\n" +
                                 "5. 全国人民代表大会：\n   - 最高国家权力机关，负责立法和制定重要政策\n\n" +
                                 "6. 政治体系：\n   - 社会主义市场经济，强调党的领导和国家发展\n\n" +
                                 "7. 军队：\n   - 中国人民解放军是中华人民共和国的武装力量\n   - 解放军受中共领导，确保国家安全和领土完整"
            };


            // 创建一个弹窗并将文本块添加到弹窗中
            MessageBox.Show(text.Text, "中国政府体系");
        }
    }
}
