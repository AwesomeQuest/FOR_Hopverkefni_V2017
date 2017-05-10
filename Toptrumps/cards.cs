using System; 
 using System.Text; 
 using System.IO; 
 using Toptrumps; 

 namespace Toptrumps { class CardDump { public void dump() { 


 TrumpBasic TT0 = new TrumpBasic("TT0", 16, 177, 170);

 TrumpBasic TT1 = new TrumpBasic("TT1", 118, 107, 182);

 TrumpBasic TT2 = new TrumpBasic("TT2", 85, 175, 134);

 TrumpBasic TT3 = new TrumpBasic("TT3", 140, 199, 148);

 TrumpBasic TT4 = new TrumpBasic("TT4", 90, 145, 42);

 TrumpBasic TT5 = new TrumpBasic("TT5", 86, 132, 90);

 TrumpBasic TT6 = new TrumpBasic("TT6", 160, 166, 111);

 TrumpBasic TT7 = new TrumpBasic("TT7", 160, 69, 130);

 TrumpBasic TT8 = new TrumpBasic("TT8", 0, 87, 134);

 TrumpBasic TT9 = new TrumpBasic("TT9", 137, 189, 189);

 TrumpBasic TTA = new TrumpBasic("TTA", 23, 40, 110);

 TrumpBasic TTB = new TrumpBasic("TTB", 133, 116, 169);

 TrumpBasic TTC = new TrumpBasic("TTC", 182, 172, 174);

 TrumpBasic TTD = new TrumpBasic("TTD", 196, 180, 29);

 TrumpBasic TTE = new TrumpBasic("TTE", 87, 55, 88);

 TrumpBasic TTF = new TrumpBasic("TTF", 195, 71, 198);

 TrumpBasic TT10 = new TrumpBasic("TT10", 45, 180, 18);

 TrumpBasic TT11 = new TrumpBasic("TT11", 65, 13, 122);

 TrumpBasic TT12 = new TrumpBasic("TT12", 156, 14, 195);

 TrumpBasic TT13 = new TrumpBasic("TT13", 21, 79, 181);

 TrumpBasic TT14 = new TrumpBasic("TT14", 196, 117, 127);

 TrumpBasic TT15 = new TrumpBasic("TT15", 95, 187, 157);

 TrumpBasic TT16 = new TrumpBasic("TT16", 58, 50, 47);

 TrumpBasic TT17 = new TrumpBasic("TT17", 100, 37, 31);

 TrumpBasic TT18 = new TrumpBasic("TT18", 42, 94, 165);

 TrumpBasic TT19 = new TrumpBasic("TT19", 98, 116, 128);

 TrumpBasic TT1A = new TrumpBasic("TT1A", 50, 73, 186);

 TrumpBasic TT1B = new TrumpBasic("TT1B", 184, 183, 62);

 TrumpBasic TT1C = new TrumpBasic("TT1C", 73, 45, 156);

 TrumpBasic TT1D = new TrumpBasic("TT1D", 143, 10, 121);

 TrumpBasic TT1E = new TrumpBasic("TT1E", 23, 197, 195);

 TrumpBasic TT1F = new TrumpBasic("TT1F", 166, 40, 0);

 TrumpBasic TT20 = new TrumpBasic("TT20", 182, 43, 2);

 TrumpBasic TT21 = new TrumpBasic("TT21", 113, 28, 145);

 TrumpBasic TT22 = new TrumpBasic("TT22", 188, 158, 137);

 TrumpBasic TT23 = new TrumpBasic("TT23", 0, 175, 35);

 TrumpBasic TT24 = new TrumpBasic("TT24", 188, 39, 8);

 TrumpBasic TT25 = new TrumpBasic("TT25", 81, 153, 8);

 TrumpBasic TT26 = new TrumpBasic("TT26", 173, 108, 129);

 TrumpBasic TT27 = new TrumpBasic("TT27", 120, 114, 2);

 TrumpBasic TT28 = new TrumpBasic("TT28", 72, 68, 198);

 TrumpBasic TT29 = new TrumpBasic("TT29", 181, 135, 93);

 TrumpBasic TT2A = new TrumpBasic("TT2A", 100, 76, 89);

 TrumpBasic TT2B = new TrumpBasic("TT2B", 73, 99, 56);

 TrumpBasic TT2C = new TrumpBasic("TT2C", 162, 121, 26);

 TrumpBasic TT2D = new TrumpBasic("TT2D", 32, 144, 37);

 TrumpBasic TT2E = new TrumpBasic("TT2E", 35, 171, 153);

 TrumpBasic TT2F = new TrumpBasic("TT2F", 99, 44, 159);

 TrumpBasic TT30 = new TrumpBasic("TT30", 155, 127, 149);

 TrumpBasic TT31 = new TrumpBasic("TT31", 176, 93, 93);

 TrumpBasic TT32 = new TrumpBasic("TT32", 146, 163, 155);

 TrumpBasic TT33 = new TrumpBasic("TT33", 64, 22, 158);

 TrumpBasic TT34 = new TrumpBasic("TT34", 51, 82, 138);

 TrumpBasic TT35 = new TrumpBasic("TT35", 87, 76, 177);

 TrumpBasic TT36 = new TrumpBasic("TT36", 30, 170, 106);

 TrumpBasic TT37 = new TrumpBasic("TT37", 181, 87, 145);

 TrumpBasic TT38 = new TrumpBasic("TT38", 116, 15, 29);

 TrumpBasic TT39 = new TrumpBasic("TT39", 150, 123, 70);

 TrumpBasic TT3A = new TrumpBasic("TT3A", 27, 173, 180);

 TrumpBasic TT3B = new TrumpBasic("TT3B", 189, 32, 164);

 TrumpBasic TT3C = new TrumpBasic("TT3C", 12, 79, 154);

 TrumpBasic TT3D = new TrumpBasic("TT3D", 105, 159, 186);

 TrumpBasic TT3E = new TrumpBasic("TT3E", 150, 20, 102);

 TrumpBasic TT3F = new TrumpBasic("TT3F", 187, 83, 71);

 TrumpBasic TT40 = new TrumpBasic("TT40", 18, 99, 88);

 TrumpBasic TT41 = new TrumpBasic("TT41", 193, 13, 124);

 TrumpBasic TT42 = new TrumpBasic("TT42", 11, 69, 171);

 TrumpBasic TT43 = new TrumpBasic("TT43", 96, 109, 139);

 TrumpBasic TT44 = new TrumpBasic("TT44", 5, 93, 197);

 TrumpBasic TT45 = new TrumpBasic("TT45", 133, 128, 150);

 TrumpBasic TT46 = new TrumpBasic("TT46", 28, 150, 194);

 TrumpBasic TT47 = new TrumpBasic("TT47", 21, 63, 81);

 TrumpBasic TT48 = new TrumpBasic("TT48", 102, 121, 49);

 TrumpBasic TT49 = new TrumpBasic("TT49", 143, 115, 19);

 TrumpBasic TT4A = new TrumpBasic("TT4A", 155, 26, 5);

 TrumpBasic TT4B = new TrumpBasic("TT4B", 188, 73, 182);

 TrumpBasic TT4C = new TrumpBasic("TT4C", 81, 104, 1);

 TrumpBasic TT4D = new TrumpBasic("TT4D", 85, 169, 125);

 TrumpBasic TT4E = new TrumpBasic("TT4E", 149, 132, 20);

 TrumpBasic TT4F = new TrumpBasic("TT4F", 18, 195, 106);

 TrumpBasic TT50 = new TrumpBasic("TT50", 188, 27, 11);

 TrumpBasic TT51 = new TrumpBasic("TT51", 60, 49, 54);

 TrumpBasic TT52 = new TrumpBasic("TT52", 74, 198, 146);

 TrumpBasic TT53 = new TrumpBasic("TT53", 122, 113, 168);

 TrumpBasic TT54 = new TrumpBasic("TT54", 167, 153, 47);

 TrumpBasic TT55 = new TrumpBasic("TT55", 62, 187, 58);

 TrumpBasic TT56 = new TrumpBasic("TT56", 195, 158, 139);

 TrumpBasic TT57 = new TrumpBasic("TT57", 94, 176, 180);

 TrumpBasic TT58 = new TrumpBasic("TT58", 120, 57, 47);

 TrumpBasic TT59 = new TrumpBasic("TT59", 62, 8, 180);

 TrumpBasic TT5A = new TrumpBasic("TT5A", 50, 111, 19);

 TrumpBasic TT5B = new TrumpBasic("TT5B", 23, 19, 168);

 TrumpBasic TT5C = new TrumpBasic("TT5C", 163, 66, 75);

 TrumpBasic TT5D = new TrumpBasic("TT5D", 147, 189, 85);

 TrumpBasic TT5E = new TrumpBasic("TT5E", 169, 78, 179);

 TrumpBasic TT5F = new TrumpBasic("TT5F", 109, 42, 194);

 TrumpBasic TT60 = new TrumpBasic("TT60", 17, 186, 185);

 TrumpBasic TT61 = new TrumpBasic("TT61", 66, 8, 92);

 TrumpBasic TT62 = new TrumpBasic("TT62", 172, 16, 66);

 TrumpBasic TT63 = new TrumpBasic("TT63", 168, 171, 109);




 } } }
