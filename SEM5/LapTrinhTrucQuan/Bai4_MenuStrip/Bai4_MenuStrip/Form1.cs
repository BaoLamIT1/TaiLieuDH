﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BaiTapDienTu baitap = new BaiTapDienTu();
        private void tsMdt1_Click(object sender, EventArgs e)
        {
            baitap.Debai = "It can take a long time to become successful in your chosen field, " +
                "however talented you are. One thing you have to be (1) _______ of is that you will face " +
                "criticism along the way. The world is (2)_________ of people who would rather say something " +
                "negative than positive. If you’ve made up your (3)_______ to achieve a certain goal, such as" +
                " writing a novel, (4)_________ the negative criticism of others prevent you from reaching your" +
                " target, and let the constructive criticism have a positive effect on your work. If someone says" +
                " you’re totally in the (5)______ of talent, ignore them. That’s negative criticism. " +
                "If (6), __________, someone advises you to revise your work and gives you a good reason for " +
                "doing so, you should consider their suggestions carefully. There are many film stars (7)__________ " +
                "were once out of work . There are many famous novelists who made a complete mess of their first novel – or " +
                "who didn’t, but had to keep on approaching hundreds of publishers before they could get it (8) ________. " +
                "Being successful does depend on luck, to a (9)________ extent. But things are more likely to " +
                "(10) ________ well if you persevere and stay positive.";

            baitap.Dapan = "It can take a long time to become successful in your chosen field, " +
                "however talented you are. One thing you have to be (1) aware of is that you will face " +
                "criticism along the way. The world is (2)full of people who would rather say something " +
                "negative than positive. If you’ve made up your (3) mind to achieve a certain goal, such as" +
                " writing a novel, (4)don't let the negative criticism of others prevent you from reaching your" +
                " target, and let the constructive criticism have a positive effect on your work. If someone says" +
                " you’re totally in the (5)lack of talent, ignore them. That’s negative criticism. " +
                "If (6),however, someone advises you to revise your work and gives you a good reason for " +
                "doing so, you should consider their suggestions carefully. There are many film stars (7) who " +
                "were once out of work . There are many famous novelists who made a complete mess of their first novel – or " +
                "who didn’t, but had to keep on approaching hundreds of publishers before they could get it (8) published. " +
                "Being successful does depend on luck, to a (9)certain extent. But things are more likely to " +
                "(10) turn out well if you persevere and stay positive.";

            List<string> list = new List<string>();
            list.Add("aware");
            list.Add("full");
            list.Add("mind");
            list.Add("don't let");
            list.Add("lack");
            list.Add("however");
            list.Add("who");
            list.Add("published");
            list.Add("certain");
            list.Add("turn out");

            baitap.Dapantungcau = list;

            StaticData.btdt = baitap;

            Form2 fom2 = new Form2();
            fom2.Show();
            
        }
       
    }
}
