using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEMALE_HEIGHT
{
    class Program
    {

        static void Main(string[] args)
        {
            int o = 0;
            int a = 0;
            int b = 0;
            int ab = 0;
            int other = 0;
            int i = 0;
            int all;
            int omg = 0;
            string[] n = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "世新徐偉哲", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            string[] blood_type = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            string[] star = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };
            for (i = 0; i < n.Length; i++)
            {
                if (blood_type[i] == "O")
                {
                    o++;
                }
                if (blood_type[i] == "A")
                {
                    a++;
                }
                if (blood_type[i] == "B")
                {
                    b++;
                }
                if (blood_type[i] == "AB")
                {
                    ab++;
                }
                if (blood_type[i] == "其他")
                {
                    other++;
                }

            }
            

            all = o + a + b + ab + other;
            double percentO = (double)o / (double)all * 100;
            double percentA = (double)a / (double)all * 100;
            double percentB = (double)b / (double)all * 100;
            double percentAB = (double)ab / (double)all * 100;
            double percentOther = (double)other / (double)all * 100;
            

            int min = 200;
            int max = 0;
            int girl_num = 0;
            int boy_num = 0;
            int male_height_sum = 0;
            int female_height_sum = 0;
            int height_sum = 0;
            int height_num = 0;
            string[] gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            int[] height = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };
            for (i = 0; i < gender.Length; i++)
            {

                if (gender[i] == "女")
                {


                    if (height[i] > 100 && height[i] < 200)
                    {
                        female_height_sum = female_height_sum + height[i];
                        girl_num++;
                    }
                }
                if (gender[i] == "男")
                {


                    if (height[i] > 100 && height[i] < 200)
                    {
                        male_height_sum = male_height_sum + height[i];
                        boy_num++;
                    }
                }
                if (height[i] > 100 && height[i] < 200)
                {
                    height_sum = height_sum + height[i];
                    height_num++;
                }
            }


           

            for (i = 0; i < height.Length; i++)
            {
                
                if (height[i] > 100 && height[i] < 200)
                {
                    if (height[i] > max)
                        max = height[i];
                    if (height[i] < min)
                        min = height[i];
                }
            }
            




            double percentBoy = (double)boy_num / (double)gender.Length*100;
            double percentGirl = (double)girl_num / (double)gender.Length * 100;
            Console.WriteLine("全班男生人數為 " + boy_num + "人  " + "佔全班 {0:0}%",percentBoy);
            Console.WriteLine("全班女生人數為 " + girl_num + "人  " + "佔全班 {0:0}%", percentGirl);
            Console.WriteLine("o型有" + o + "人" + "佔 {0:0} %", percentO);
            Console.WriteLine("A型有" + a + "人" + "佔 {0:0} %", percentA);
            Console.WriteLine("B型有" + b + "人" + "佔 {0:0} %", percentB);
            Console.WriteLine("AB型有" + ab + "人" + "佔 {0:0} %", percentAB);
            Console.WriteLine("其他有" + other + "人" + "佔 {0:0} %", percentOther);
            Console.WriteLine("男生身高平均 = " + male_height_sum / boy_num);
            Console.WriteLine("女生身高平均 = " + female_height_sum / girl_num);
            Console.WriteLine("全班身高平均 = " + height_sum / height_num);
            for (i = 0; i < n.Length; i++)
            {
                if (star[i] == "天蠍" && blood_type[i] == "O")
                    Console.WriteLine("天蠍座又ｏ型的人  " + n[i]);
            }
            //Console.WriteLine("全班最高為 " + max);
            //Console.WriteLine("全班最矮為 " + min);

            Console.ReadLine();
        }
    }
}
