using System;
using System.Collections.Generic;
using System.Text;
using eShopOnContainers.Core.Models.MyProduct;

namespace eShopOnContainers.Core.Services.MyProduct
{
    public class ProductMockService : IProductService
    {
        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>()
            {
               new Product
               {
                   Id=1,
                   CategoryId=1,
                   SubCategoryId=1,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/098/291/5fa93943cd3be.jpeg?v=201910111500",
                   Title="POSXPOWER 1512 DOKUNMATİK BİLGİSAYAR POS PC",
                   Price=5850
               },
               new Product
               {
                   Id=2,
                   CategoryId=1,
                   SubCategoryId=1,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/107/638/6076eb1522f5d.jpg?v=201910111519",
                   Title="İzoly Jailor Ti RYZEN 7 3700X 16GB 256SSD M.2 GDDR5 GTX1050Ti Ekran Kartlı 24 Oyuncu PC",
                   Price=9814
               },
               new Product
               {
                   Id=3,
                   CategoryId=1,
                   SubCategoryId=1,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/039/499/59e79cf12547e.jpeg?v=201910111500",
                   Title="Frisby FC-9235G 650W 80 Plus Pencereli 4x120mm Fanlı Gaming Oyuncu Bilgisayar Kasası",
                   Price=749
               },
               new Product
               {
                   Id=4,
                   CategoryId=1,
                   SubCategoryId=1,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/106/248/6061d0c3bf326.jpeg?v=201910111500",
                   Title="SNC ALFA 2101",
                   Price=7297
               },
               new Product
               {
                   Id=5,
                   CategoryId=1,
                   SubCategoryId=1,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/107/963/607ebc26787cf.jpg?v=201910111500",
                   Title="İzoly Kobe RYZEN 3 2200G 8GB 256SSD + 500GB GDDR5 GTX 1650 Ekran Kartlı 24 Oyuncu PC",
                   Price=8948
               },
                new Product
               {
                   Id=6,
                   CategoryId=1,
                   SubCategoryId=1,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img.epttavm.com/pimages/592/104/620/604b603283c8d.jpeg?v=201910111500",
                   Title="Everest WİNNER PRO EW-2021 Beyaz Wifi+BT 2*Kamera 7 LCD Ekran A100 Quard Core 2GB+16GB And.10 OS Tablet PC",
                   Price=559
               },new Product
               {
                   Id=7,
                   CategoryId=1,
                   SubCategoryId=1,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/094/192/5f311a7bb71c0.jpg?v=201910111500",
                   Title="Plastik USB Bellek - 8113, 16 GB, Gümüş",
                   Price=129
               },new Product
               {
                   Id=8,
                   CategoryId=1,
                   SubCategoryId=1,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/057/567/5efaf66750da7.jpg?v=201910111500",
                   Title="İNTEL AMD COMBO İŞLEMCİ FANI Q8",
                   Price=37
               },new Product
               {
                   Id=9,
                   CategoryId=1,
                   SubCategoryId=1,
                   SubOfSubCategoryId=5,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/098/201/5fa5abf9a5201.jpeg?v=201910111500",
                   Title="K8 Kamuflaj Gaming Profesyonel Led Işıklı Oyuncu Kulaklığı ONİKUMA",
                   Price=172
               },new Product
               {
                   Id=10,
                   CategoryId=1,
                   SubCategoryId=1,
                   SubOfSubCategoryId=6,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/088/627/5e674f329ba8a.jpg?v=201910111500",
                   Title="21.5 VIEWSONIC VG2239SMH-2 FHD VA PANEL 5MS D-SUB+DP+HDMI+USB MM ERGONOMIK KURUMSAL MONITOR",
                   Price=1445
               },new Product
               {
                   Id=11,
                   CategoryId=1,
                   SubCategoryId=1,
                   SubOfSubCategoryId=7,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/099/279/5fc61c2516d7d.png?v=201910111500",
                   Title="ESET Smart Security Premium",
                   Price=515
               },new Product
               {
                   Id=12,
                   CategoryId=1,
                   SubCategoryId=1,
                   SubOfSubCategoryId=8,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/097/236/5f881ffd3bbd3.png?v=201910111500",
                   Title="Keenetic Giga KN-1010-01TR 1300 Mbps 5 Ghz Access Point & Router",
                   Price=779
               },
               //Beyaz Eşya
                new Product
               {
                   Id=13,
                   CategoryId=1,
                   SubCategoryId=2,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/102/841/6024066438b98.png?v=201910111500",
                   Title="BOSCH Çamaşır Makinesi 10 kg 1400 dev./dak., silver WAX28M8XTR",
                   Price=10266
               },
                new Product
               {
                   Id=14,
                   CategoryId=1,
                   SubCategoryId=2,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/097/362/5f8a32d7811d2.png?v=201910111500",
                   Title="LG DFB512FP A++ 8 Programlı Çelik Bulaşık Makinesi",
                   Price=4699
               },
                new Product
               {
                   Id=15,
                   CategoryId=1,
                   SubCategoryId=2,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/045/821/5fe483a0dc563.jpeg?v=201910111500",
                   Title="LUXELL SİYAH BASİC ANKASTRE SET",
                   Price=1450
               },
                new Product
               {
                   Id=16,
                   CategoryId=1,
                   SubCategoryId=2,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/053/771/5b9a464342f66.jpeg?v=201910111500",
                   Title="Electrolux EFV60656OW Beyaz Davlumbaz",
                   Price=2200
               },
                new Product
               {
                   Id=17,
                   CategoryId=1,
                   SubCategoryId=2,
                   SubOfSubCategoryId=5,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/101/501/6006d9b44a16b.jpg?v=201910111500",
                   Title="Whitedaisy Çift Motorlu Mutfak Aspiratörü F2 ASPİRATÖR",
                   Price=271
               },
                // Elektrikli Ev Aletleri
                new Product
               {
                   Id=18,
                   CategoryId=1,
                   SubCategoryId=3,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/101/011/5ff997ac89405.jpeg?v=201910111500",
                   Title="Remta Elegance Portakal Sıkma Makinası",
                   Price=830
               },
                new Product
               {
                   Id=19,
                   CategoryId=1,
                   SubCategoryId=3,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/099/281/5fc630371bb9d.jpeg?v=201910111500",
                   Title="Roidmi X30 Pro 28.8V Kablosuz Dikey Süpürge (Roidmi Türkiye Garantili)",
                   Price=4999
               },
                new Product
               {
                   Id=20,
                   CategoryId=1,
                   SubCategoryId=3,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/096/821/5f7db2eb51386.jpg?v=201910111500",
                   Title="Hotpoint-Ariston 82731 II DC60 AA0 2800W Elmas Tabanlı Ütü",
                   Price=639
               },
                new Product
               {
                   Id=21,
                   CategoryId=1,
                   SubCategoryId=3,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/085/815/5e255a2ee4fdb.jpeg?v=201910111500",
                   Title="Juki HZL-K65 Ev Tipi Elektronik Dikiş Ve Piko Makinesi",
                   Price=2198
               },
                //Telefon ve Aksesuarları
                new Product
               {
                   Id=22,
                   CategoryId=1,
                   SubCategoryId=4,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/059/703/5f3e56f47d5ea.jpeg?v=201910111500",
                   Title="General Mobile GM9 pro - General Mobile Garantili GOLD",
                   Price=2989
               },
                new Product
               {
                   Id=23,
                   CategoryId=1,
                   SubCategoryId=4,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/093/689/5f1aebd8925f9.jpeg?v=201910111500",
                   Title="Olix Airpods Pro Wifi Şarj Kutulu Bluetooth Kulaklık",
                   Price=499,
               },
                new Product
               {
                   Id=24,
                   CategoryId=1,
                   SubCategoryId=4,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/100/431/5fe5a75eb1dba.jpg?v=201910111500",
                   Title="Quark QSM-107-1 Akıllı Saat",
                   Price=654
               },
                new Product
               {
                   Id=25,
                   CategoryId=1,
                   SubCategoryId=4,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/099/908/5fd91a8326cfe.jpeg?v=201910111500",
                   Title="Iphone X Bix Yüksek Amperli Garantili Batarya Pil",
                   Price=239
               },
                new Product
               {
                   Id=26,
                   CategoryId=1,
                   SubCategoryId=4,
                   SubOfSubCategoryId=5,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/091/268/5ed137d7b56fe.jpg?v=201910111500",
                   Title="Gigaset Maxwell C Desktop Phone",
                   Price=731
               },
                //Televizyon ve Ses Sistemleri
                new Product
               {
                   Id=27,
                   CategoryId=1,
                   SubCategoryId=5,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/100/909/5ff72005e8c46.jpeg?v=201910111500",
                   Title="Hi-Level HL43DLK13 43 109 Ekran Uydu Alıcılı Smart Wi-Fi LED Tv",
                   Price=2749
               },
                new Product
               {
                   Id=28,
                   CategoryId=1,
                   SubCategoryId=5,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/093/467/5f168f9bc4986.jpeg?v=201910111500",
                   Title="Etiasglass Regal 49R7560UA Tv Ekran Koruycu/ 3mm Ekran Koruma Camı",
                   Price=449
               },
                new Product
               {
                   Id=29,
                   CategoryId=1,
                   SubCategoryId=5,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/100/285/5fe104bb447cc.png?v=201910111500",
                   Title="Goldmaster HD-1060 PVR Dijital Uydu Alıcısı",
                   Price=390
               },
                new Product
               {
                   Id=30,
                   CategoryId=1,
                   SubCategoryId=5,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/041/571/5a33c263d4a30.png?v=201910111500",
                   Title="Ayna Renk Ters Projeksiyon Film",
                   Price=2072
               },
                new Product
               {
                   Id=31,
                   CategoryId=1,
                   SubCategoryId=5,
                   SubOfSubCategoryId=5,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/094/141/5f2e903f6e641.jpg?v=201910111500",
                   Title="MUSIC IŞIKLI BLUETOOTH MİNİ HOPARLÖR SES BOMBASI",
                   Price=42
               },
                //Isıtma ve Sogutma Sistemeleri
                new Product
               {
                   Id=32,
                   CategoryId=1,
                   SubCategoryId=6,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/074/167/5e167f89263d8.jpg?v=201910111519",
                   Title="Termodinamik Dek 18 Kw Trifaze Elektrikli Kombi",
                   Price=4500
               },
                new Product
               {
                   Id=33,
                   CategoryId=1,
                   SubCategoryId=6,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/101/558/600841586026f.jpeg?v=201910111500",
                   Title="Sercair Spirit Filtre",
                   Price=99
               },
                new Product
               {
                   Id=34,
                   CategoryId=1,
                   SubCategoryId=6,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/097/387/5f8b55ef8b7a8.jpg?v=201910111500",
                   Title="GENERAL HT250S SET Kablosuz Oda Termostatı PURJÖR ANAHTARI HEDİYELİ",
                   Price=342
               },
                new Product
               {
                   Id=35,
                   CategoryId=1,
                   SubCategoryId=6,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/103/359/602e763314e20.png?v=201910111500",
                   Title="VESTFROST 65 TERMOSİFON 65 LT",
                   Price=1299
               },
                new Product
               {
                   Id=36,
                   CategoryId=1,
                   SubCategoryId=6,
                   SubOfSubCategoryId=5,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/099/842/5fd7420626680.jpeg?v=201910111500",
                   Title="Hometta Pandora Fanlı Isıtıcı",
                   Price=165
               },
                //Akıllı Güvenlik Sistemleri
                new Product
               {
                   Id=37,
                   CategoryId=1,
                   SubCategoryId=7,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/100/285/5fe104b6e20cc.jpg?v=201910111500",
                   Title="Goldmaster GHC-4220DF 2MP 3.6MM IR DOME AHD KAMERA",
                   Price=165
               },
                new Product
               {
                   Id=38,
                   CategoryId=1,
                   SubCategoryId=7,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/054/887/5bb7763527e7c.jpeg?v=201910111500",
                   Title="BT-NV108/8P",
                   Price=1572
               },
                new Product
               {
                   Id=39,
                   CategoryId=1,
                   SubCategoryId=7,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/087/452/5e4be497478dc.jpeg?v=201910111500",
                   Title="Haikon DS-3E0109P-E SWICH",
                   Price=522
               },
                new Product
               {
                   Id=40,
                   CategoryId=1,
                   SubCategoryId=7,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/107/613/6076b4899b7ed.jpg?v=201910111500",
                   Title="Longline LC-LC Fiber Optik Patch Kablo, 15 metre Single Mode LNGG652A1-15MTLC",
                   Price=42
               },
                new Product
               {
                   Id=41,
                   CategoryId=1,
                   SubCategoryId=7,
                   SubOfSubCategoryId=5,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/064/285/5c8a793511e1d.jpeg?v=201910111500",
                   Title="TD-200 Telefon Arama Modülü",
                   Price=440
               },
                //Giyim Ve Aksesuar
                //Kadın
                new Product
               {
                   Id=42,
                   CategoryId=2,
                   SubCategoryId=1,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/100/337/5fe2ebef7ed9b.jpg?v=201910111500",
                   Title="Kadın Eşofman Altı Bel İpli Baskılı Jogger Spor Alt 1618",
                   Price=39
               },
                new Product
               {
                   Id=43,
                   CategoryId=2,
                   SubCategoryId=1,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/090/372/5eaa92e9358d8.jpg?v=201910111500",
                   Title="etoile Kadın Yazlık Kısa Kol Bambu Pijama Takımı",
                   Price=195
               },new Product
               {
                   Id=44,
                   CategoryId=2,
                   SubCategoryId=1,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/091/634/5edffe81ee9c7.jpg?v=201910111500",
                   Title="Remsa Mayo Tesettür Mayo Üzerine Desenli Tek Kaftan Pareo Papağan Tropik",
                   Price=199
               },new Product
               {
                   Id=45,
                   CategoryId=2,
                   SubCategoryId=1,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/091/511/5ede1504daac4.jpeg?v=201910111500",
                   Title="Lir Kadın Büyük Beden Uzun kol Leopar Desen Elbise Siyah L1609",
                   Price=99
               },new Product
               {
                   Id=46,
                   CategoryId=2,
                   SubCategoryId=1,
                   SubOfSubCategoryId=5,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/092/625/5efa2dbcdbcd0.jpg?v=201910111500",
                   Title="Föz Beyaz Yüksek Platformlu Kadın Topuklu Ayakkabı 12 Cm A28",
                   Price=154
               },
                //Erkek
                new Product
               {
                   Id=47,
                   CategoryId=2,
                   SubCategoryId=2,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/094/180/5f2fe5df8d1c8.jpg?v=201910111500",
                   Title="DAFRON PARK ANTRENMAN ŞORT - AS17100-00L",
                   Price=59
               },new Product
               {
                   Id=48,
                   CategoryId=2,
                   SubCategoryId=2,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/100/339/5fe2ed260ebda.png?v=201910111500",
                   Title="Erkek V Yaka Body Premier Sıfır Kol Atlet Fanila 2li Paket Namal",
                   Price=46
               },new Product
               {
                   Id=49,
                   CategoryId=2,
                   SubCategoryId=2,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/097/037/5f8308642be63.jpg?v=201910111500",
                   Title="Erkek Salaş Kesim Owersize Bisiklet Yaka Eteği Beyaz Catch Sweatshirt -Kırmızı",
                   Price=139
               },new Product
               {
                   Id=50,
                   CategoryId=2,
                   SubCategoryId=2,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/093/817/5f32567c770c3.jpg?v=201910111500",
                   Title="VOYAGER 2690 DERI ORTOPEDİ ERKEK BOT",
                   Price=239
               },new Product
               {
                   Id=51,
                   CategoryId=2,
                   SubCategoryId=2,
                   SubOfSubCategoryId=5,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/098/127/5fa4095fea4cb.jpg?v=201910111500",
                   Title="DS Damat Kemer Telefon Cüzdan Set",
                   Price=320
               },
                //Çocuk Giyim 
                new Product
               {
                   Id=52,
                   CategoryId=2,
                   SubCategoryId=3,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/101/282/5fffdfe9f2dd9.jpg?v=201910111500",
                   Title="KIZ ÇOCUK BATİK TEK ALT EŞOFMAN 12-15 YAŞ",
                   Price=47
               },new Product
               {
                   Id=53,
                   CategoryId=2,
                   SubCategoryId=3,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/101/419/6004b1bfa093b.jpg?v=201910111500",
                   Title="Yavrucak Kids Erkek Çocuk Yazlık Penye İkili Takım",
                   Price=53
               },
                //Ayakkabı Bakım
                new Product
               {
                   Id=54,
                   CategoryId=2,
                   SubCategoryId=4,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/104/737/604da6a49bba6.jpeg?v=201910111500",
                   Title="Yaylı Ayakkabı Kalıbı 39-45 Numara 5 Çift",
                   Price=52
               },new Product
               {
                   Id=55,
                   CategoryId=2,
                   SubCategoryId=4,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/061/760/5c5d1b25d48eb.jpg?v=201910111500",
                   Title="ERKEK AYAKKABI SAKLAMA KUTUSU KİLİTLİ",
                   Price=24
               },new Product
               {
                   Id=56,
                   CategoryId=2,
                   SubCategoryId=4,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/101/963/6013fc0d4e7ee.jpeg?v=201910111500",
                   Title="Bağmatik Turuncu",
                   Price=29
               },new Product
               {
                   Id=57,
                   CategoryId=2,
                   SubCategoryId=4,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/095/527/5fff72f6e1ba7.png?v=201910111500",
                   Title="TOPUK DİKENİ TERLİĞİ AYAKKABI TERLİK ALTLIĞI ÜRÜNLERİ TABANLIK",
                   Price=34
               },new Product
               {
                   Id=58,
                   CategoryId=2,
                   SubCategoryId=4,
                   SubOfSubCategoryId=5,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/102/052/6017b34156fa2.jpg?v=201910111500",
                   Title="Rose Cilt Temizleme Fırçası",
                   Price=34
               },
                //Bavul
                new Product
               {
                   Id=59,
                   CategoryId=2,
                   SubCategoryId=5,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/092/088/5ef119b761743.jpg?v=201910111500",
                   Title="EHS Kabin Boy Valiz Abs Lacivert",
                   Price=199
               },new Product
               {
                   Id=60,
                   CategoryId=2,
                   SubCategoryId=5,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/091/987/5ff1961b3b38a.jpg?v=201910111500",
                   Title="Verage Siyah Kumaş 3lü Valiz Seti",
                   Price=1799
               },new Product
               {
                   Id=61,
                   CategoryId=2,
                   SubCategoryId=5,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/099/623/5fcf87aaadb84.jpg?v=201910111500",
                   Title="Elatae Büyük Boy Valiz Kılıfı Likralı",
                   Price=79
               },new Product
               {
                   Id=62,
                   CategoryId=2,
                   SubCategoryId=5,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/093/166/5f0c61de7b68c.jpg?v=201910111500",
                   Title="Trunki Çocuk Bavulu - Peri Flora",
                   Price=548
               },
                //Kozmetik
                  //kozmetik

                new Product
               {
                   Id=63,
                   CategoryId=3,
                   SubCategoryId=1,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/098/119/5fa3e492e2561.jpg?v=201910111500",
                   Title="FİRST CLASS EDT KOFRE 100ML+150ML",
                   Price=90
               },new Product
               {
                   Id=64,
                   CategoryId=3,
                   SubCategoryId=1,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/093/117/5f0b082f241eb.jpeg?v=201910111500",
                   Title="Dara Hakiki Arap Kızı Kremi Seti Gece ve Gündüz 20 ml + 20 ml",
                   Price=31
               },new Product
               {
                   Id=65,
                   CategoryId=3,
                   SubCategoryId=1,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/094/622/5f3e65c8838f9.jpeg?v=201910111500",
                   Title="OCEAN 3D İPEK KİRPİK - 39 - 10 KUTU",
                   Price=129
               },new Product
               {
                   Id=66,
                   CategoryId=3,
                   SubCategoryId=1,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/064/789/5c922fae2e7b0.jpeg?v=201910111500",
                   Title="Dr AppliCare Sebiac Krem 50 SPF 150 ml",
                   Price=175
               },new Product
               {
                   Id=67,
                   CategoryId=3,
                   SubCategoryId=1,
                   SubOfSubCategoryId=5,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/096/247/5f71f8d029014.jpg?v=201910111500",
                   Title="Nemlendirici & Besleyici Cilt Bakım Gümüş Kremi",
                   Price=99
               },
                //Kişisel Bakım
                new Product
               {
                   Id=68,
                   CategoryId=3,
                   SubCategoryId=2,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/098/119/5fa3e48f1c6d5.jpg?v=201910111500",
                   Title="SENSODYNE 75ML GENTLE WHİTENİNG",
                   Price=22
               },
                //Anne Bebek
                new Product
               {
                   Id=69,
                   CategoryId=4,
                   SubCategoryId=1,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/095/719/5f5e6c7724e71.jpeg?v=201910111500",
                   Title="Playgro Zebra Aktivite Oyuncağı Diş Kaşıyıcı Çıngırak Pembe",
                   Price=100
               },new Product
               {
                   Id=70,
                   CategoryId=4,
                   SubCategoryId=1,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/087/840/5e552cdb74f11.jpg?v=201910111500",
                   Title="Kumaş Ahşap Diş Kaşıyıcı Bluish",
                   Price=39
               },new Product
               {
                   Id=71,
                   CategoryId=4,
                   SubCategoryId=1,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/097/084/5f84656127e9c.jpg?v=201910111500",
                   Title="Pembe Beyaz Puanlı Hoppala",
                   Price=59
               },new Product
               {
                   Id=72,
                   CategoryId=4,
                   SubCategoryId=1,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/104/287/6042953e76bf5.jpg?v=201910111500",
                   Title="Okbaby Pasha Koltuk Oturak / Pembe",
                   Price=144
               },new Product
               {
                   Id=73,
                   CategoryId=4,
                   SubCategoryId=1,
                   SubOfSubCategoryId=5,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/060/741/5c472d31cc8c7.jpg?v=201910111500",
                   Title="Damla oyuncak amigurumi örgü oyuncak peluş oyuncak",
                   Price=79
               },
                //Oto Koltugu
                new Product
               {
                   Id=74,
                   CategoryId=4,
                   SubCategoryId=2,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/103/928/603cc2d05defa.jpeg?v=201910111500",
                   Title="Babynest-Bebek Yatağı",
                   Price=90
               },new Product
               {
                   Id=75,
                   CategoryId=4,
                   SubCategoryId=2,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/104/288/6042a68c56750.jpg?v=201910111500",
                   Title="ComfyMax 0-13kg Ana kucağı Oto koltuğu - Joy",
                   Price=339
               },new Product
               {
                   Id=76,
                   CategoryId=4,
                   SubCategoryId=2,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/089/249/5e74db6e5f471.jpg?v=201910111500",
                   Title="Koltuk Arkası Cepli Organizer(Siyah)",
                   Price=39
               },new Product
               {
                   Id=77,
                   CategoryId=4,
                   SubCategoryId=2,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/102/297/601bc7cea5043.jpeg?v=201910111500",
                   Title="YummyofBaby Arı Kuş Desenli Puset Minderi",
                   Price=79
               },
                //Bebek Bezi 
                new Product
               {
                   Id=78,
                   CategoryId=4,
                   SubCategoryId=3,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/094/257/5f3304c138340.jpeg?v=201910111500",
                   Title="Baby&Me Aloe Vera Yenidoğan 1 Bebek Bezi 2 - 5 kg 50 Adet",
                   Price=71
               },new Product
               {
                   Id=79,
                   CategoryId=4,
                   SubCategoryId=3,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/059/842/5c34554f14340.png?v=201910111500",
                   Title="Sleepy Islak Havlu Sensitive 90 lı 24 Paket 2160 Yaprak",
                   Price=149
               },new Product
               {
                   Id=80,
                   CategoryId=4,
                   SubCategoryId=3,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/069/686/5cdc11aee6fa6.jpg?v=201910111500",
                   Title="Babynest Gri Küçük Yıldızlı Açık Gri Alt Açma",
                   Price=59
               },
                //Bebek Giyim 
                new Product
               {
                   Id=81,
                   CategoryId=4,
                   SubCategoryId=4,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/101/403/600432fdc7e36.jpg?v=201910111500",
                   Title="Tongs Baby Cute Deer Bady",
                   Price=61
               },new Product
               {
                   Id=82,
                   CategoryId=4,
                   SubCategoryId=4,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/101/405/60044921e22de.jpg?v=201910111500",
                   Title="Tongs Baby Bebek Helikopter Zıbın Seti",
                   Price=71
               },
                //bebek Güvenliği
                new Product
               {
                   Id=83,
                   CategoryId=4,
                   SubCategoryId=5,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/104/288/6042a6efae73c.jpg?v=201910111500",
                   Title="Chicco Görüntülü Bebek Telsizi Smart 260",
                   Price=1552
               },new Product
               {
                   Id=84,
                   CategoryId=4,
                   SubCategoryId=5,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/101/134/5ffdb4a2a70b2.jpeg?v=201910111500",
                   Title="Motorola MBP482ANXL Dijital Bebek Kamerası -2.8 inç",
                   Price=599
               },new Product
               {
                   Id=85,
                   CategoryId=4,
                   SubCategoryId=5,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/097/241/5f88336fbdbda.jpg?v=201910111500",
                   Title="Seta Çocuk Kapı Parmak Koruyucu Stoper 6 Farklı Model 5 Renk 12 A",
                   Price=33
               },new Product
               {
                   Id=86,
                   CategoryId=4,
                   SubCategoryId=5,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/101/971/60141918813dd.jpg?v=201910111500",
                   Title="Vantuzlu-Klipsli Araç içi Bebek Dikiz Aynası",
                   Price=65
               },new Product
               {
                   Id=87,
                   CategoryId=4,
                   SubCategoryId=5,
                   SubOfSubCategoryId=5,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/101/959/6013e9526f5d1.jpg?v=201910111500",
                   Title="MİNY BABY MULTİ PRİZ GÜVENLİĞİ KUTUSU",
                   Price=49
               },
                //Bebek Maması
                new Product
               {
                   Id=88,
                   CategoryId=4,
                   SubCategoryId=6,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/097/377/5f8abe176cc8a.jpeg?v=201910111500",
                   Title="HIPP BIBERON 350 GR 2 COMBIOTIC",
                   Price=92
               },new Product
               {
                   Id=89,
                   CategoryId=4,
                   SubCategoryId=6,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/101/396/600370d45c377.jpg?v=201910111500",
                   Title="Babytime Silikon Mama Kaşığı 2li BT113",
                   Price=23
               },new Product
               {
                   Id=90,
                   CategoryId=4,
                   SubCategoryId=6,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/103/537/6032552244876.jpeg?v=201910111500",
                   Title="BEBİVİTA SÜTLAÇ 6*125GR",
                   Price=19
               },
                new Product
               {
                   Id=91,
                   CategoryId=4,
                   SubCategoryId=6,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/099/439/5fc8e417c4c39.jpeg?v=201910111500",
                   Title="Mothersmart Kidmins Bağışıklık Sistemini Destekleyici Beta Glukan İçeren Çocuk Vitamini 24'lü",
                   Price=59
               },
                //Biberron Emzik
                new Product
               {
                   Id=92,
                   CategoryId=4,
                   SubCategoryId=7,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/101/396/60036e8e26744.jpg?v=201910111500",
                   Title="Babytime Emzik Emizk Askısı ve Saklama Kabı BT199",
                   Price=33
               },new Product
               {
                   Id=93,
                   CategoryId=4,
                   SubCategoryId=7,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/101/298/60006160eef4e.jpg?v=201910111500",
                   Title="Hanymish 491 Meyve Süzgeci - Mor",
                   Price=15
               },new Product
               {
                   Id=94,
                   CategoryId=4,
                   SubCategoryId=7,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/101/340/60018ebd51c18.jpeg?v=201910111500",
                   Title="Kaşık Biberon 125 ml",
                   Price=67
               },
                //Ev Dekorasyon 
                //Perdeler
                new Product
               {
                   Id=95,
                   CategoryId=5,
                   SubCategoryId=1,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/098/534/5fb1ad5a8d60b.jpg?v=201910111500",
                   Title="My Mob Venezia Dresuar",
                   Price=299
               },new Product
               {
                   Id=96,
                   CategoryId=5,
                   SubCategoryId=1,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/100/832/5ff5a07fbb14c.png?v=201910111500",
                   Title="Bicabin Mutfak Kabini Aspiratör Üst",
                   Price=513
               },new Product
               {
                   Id=97,
                   CategoryId=5,
                   SubCategoryId=1,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/096/895/5f7f1e663c363.jpeg?v=201910111500",
                   Title="ERVA FLORYA ÜÇLÜ SET SANDIK-KUPA",
                   Price=899
               },new Product
               {
                   Id=98,
                   CategoryId=5,
                   SubCategoryId=1,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/100/142/5fdc85722dc13.jpeg?v=201910111500",
                   Title="ALASKA ÇALIŞMA MASASI",
                   Price=899
               },new Product
               {
                   Id=99,
                   CategoryId=5,
                   SubCategoryId=1,
                   SubOfSubCategoryId=5,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/064/264/5c8a1acaafbcb.jpeg?v=201910111500",
                   Title="ALWAYSSTAR 667 Masif Ahşap Ayaklı Dekoratif Yemek Masa Takımı",
                   Price=1499
               },
                //Banyo 
                new Product
               {
                   Id=100,
                   CategoryId=5,
                   SubCategoryId=2,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/099/821/5fd6a0c7f2537.jpg?v=201910111500",
                   Title="LAZER KESİM FON PERDE",
                   Price=249
               },new Product
               {
                   Id=101,
                   CategoryId=5,
                   SubCategoryId=2,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/096/888/5f7f0d671d17e.jpg?v=201910111500",
                   Title="Peştemal Rota Sarı",
                   Price=28
               },new Product
               {
                   Id=102,
                   CategoryId=5,
                   SubCategoryId=2,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/096/169/5f6e1bbf16d22.jpg?v=201910111500",
                   Title="Hobby Çift Kişilik Saten Nevresim Takımı Stripe Gül",
                   Price=349
               },new Product
               {
                   Id=103,
                   CategoryId=5,
                   SubCategoryId=2,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/096/046/5f6b1e0adf6e3.jpg?v=201910111500",
                   Title="Othello Classico Micra Tek Kişilik 155X215 Mikro Elyaf Yorgan",
                   Price=229
               },new Product
               {
                   Id=104,
                   CategoryId=5,
                   SubCategoryId=2,
                   SubOfSubCategoryId=5,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/091/283/5ed290d6e42bb.jpg?v=201910111500",
                   Title="COMFORT TORBA YAYLI YATAK CIFT KISILIK 180x200",
                   Price=889
               },
                //Mutfak Araçları ve Gereçleri
                new Product
               {
                   Id=105,
                   CategoryId=5,
                   SubCategoryId=3,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/093/686/5fce9420340af.jpeg?v=201910111500",
                   Title="Çubuk Model Yemek Bıçak 304 Kalite 3 Mm 12 Kişilik",
                   Price=166
               },new Product
               {
                   Id=106,
                   CategoryId=5,
                   SubCategoryId=3,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/098/067/5fa299360a02c.jpg?v=201910111500",
                   Title="Lava Döküm Yuvarlak Tencere Çap 32 cm Turuncu",
                   Price=1038
               },new Product
               {
                   Id=107,
                   CategoryId=5,
                   SubCategoryId=3,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/092/187/5ef37bb043899.jpeg?v=201910111500",
                   Title="Remetta Pratico Plus OTAMATİK KAPAK Düdüklü Tencere 5 LİTRE 7 LİTRE 9 LİTRE",
                   Price=330
               },new Product
               {
                   Id=108,
                   CategoryId=5,
                   SubCategoryId=3,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/094/137/5f2e650e9b0df.jpeg?v=201910111500",
                   Title="Mehtap Fiore 3&#039;lü Bordo Güveç Seti 16cm-18cm-20cm",
                   Price=169
               },new Product
               {
                   Id=109,
                   CategoryId=5,
                   SubCategoryId=3,
                   SubOfSubCategoryId=5,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/096/055/5f6b4698a512a.jpg?v=201910111500",
                   Title="Pierre Cardin Raphael 35 Parça Porselen Kahvaltı Takımı Beyaz",
                   Price=990
               },
                //Dekorasyon
                new Product
               {
                   Id=110,
                   CategoryId=5,
                   SubCategoryId=4,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/095/778/5f60bad361ebc.jpg?v=201910111500",
                   Title="Ferforje Bisiklet Şişe Tutucu Dekoratif Şaraplık",
                   Price=134
               },
                new Product
               {
                   Id=111,
                   CategoryId=5,
                   SubCategoryId=4,
                   SubOfSubCategoryId=2,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/101/332/60017fe480ea5.jpg?v=201910111500",
                   Title="Ahşap Takı & Mücevher Kutusu",
                   Price=127
               },new Product
               {
                   Id=112,
                   CategoryId=5,
                   SubCategoryId=4,
                   SubOfSubCategoryId=3,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/095/478/5f56b033c1840.jpg?v=201910111500",
                   Title="Dekoratif Golf Oynayan Adam Görünümlü Poliresin Biblo 25cm x 15cm",
                   Price=114
               },new Product
               {
                   Id=113,
                   CategoryId=5,
                   SubCategoryId=4,
                   SubOfSubCategoryId=4,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/101/342/600191ec1ad8a.jpg?v=201910111500",
                   Title="Ahşap Kapaklı Balkabağı Dekoratif Kase",
                   Price=204
               },
                //Banyo
                new Product
               {
                   Id=114,
                   CategoryId=5,
                   SubCategoryId=5,
                   SubOfSubCategoryId=1,
                   ProductIconSource="https://img-pttavm.mncdn.com/pimages/592/097/339/5f898387579ca.jpg?v=201910111500",
                   Title="Defne Banyo Begonya Siyah Kapaklı Kağıtlık",
                   Price=87
               },
               // Hobi oyuncak
                
            };

            return products;
        }

        public List<Product> GetProducts(ProductFilter productFilter)
        {
            throw new NotImplementedException();
        }
    }
}
