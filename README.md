# BIL2012-homework
1. Ödevin Amacı

Bu proje kalıtım, soyut sınıflar, arayüzler ve çok biçimlilik gibi temel nesne yönelimli kavramları pratik bir senaryo üzerinden uygulamanızı amaçlar.

2. Senaryo

Kurgusal “Anadolu Teknoloji Üniversitesi” akademik ve idari personelini tek bir konsol uygulamasıyla yönetmek istemektedir.  

Anadolu Teknoloji Üniversitesi bünyesinde Profesör, Doçent, Dr. Öğretim üyesi kadrosunda ders verme yetkisine sahip akademisyenlere sahiptir. Bunun yanında üniversitemizde idari görevde çalışan memur ve teknik personel mevcuttur.

Üniversite bünyesinde 1 Profesör, 2 Doçent, 3 Dr. Öğretim üyesi, 2 araştırma görevlisi, 2 memur, 1 teknik personel çalışmaktadır. Her bir personel personel sınıfından türetilmelidir. Personellerin maaşları akademik ve idari görevlerine göre değişiklik göstermektedir.

Sistemdeki personelimiz Haziran ayında enflasyon farkı olarak akademisyenler %20 sabit ve %50 ders saati zammı, idari personel %30 zam almıştır. Maaş zam işlemlerini bir arayüz üzerinden gerçekleştirmeniz beklenmektedir.

Tablo 1. Personel ücretleri (TL)

| Personel Türü         | Maaş Hesaplama                                   |
|-----------------------|--------------------------------------------------|
| Profesör              | Sabit ücret (200.000) + (ders saati *3000)     |
| Doçent                | Sabit ücret (160.000) + (ders saati *2000)     |
| Dr. Öğretim üyesi    | Sabit ücret (130.000) + (ders saati *1000)     |
| Araştırma Görevlisi  | Sabit ücret (100.000)                            |
| Memur                 | Sabit ücret (90.000)                             |
| Teknik Personel       | Sabit ücret (96.000)                            |

Program gerçekleştiriminizde kalıtım, çok biçimlilik, arayüz özelliklerini (8- Arayüzler.pdf ‘e kadar) uygulamanız beklenmektedir.

Anadolu Teknoloji Üniversitesi’nin birinci aydan, on ikinci aya kadar personellerine ödediği ücreti simüle eden programı yazınız.

Akademik ve idari personelin personel sınıfından türetilmesine dikkat ediniz.

Maaş zamlarının bir arayüz üzerinden gerçekleştiriniz.

Her ay adım adım personellerin türlerine göre ödenen maaşı ve aylık toplam üniversitenin personel giderini veriniz. Bunun yanında 12 ay sonunda üniversitenin toplam personel giderini ekranda gösterimiz. 

Sisteme çalışan ekleme, maaş hesaplama, zam uygulama ve tüm çalışanları listeleme işlevleri dâhildir.

3. Temel Gereksinimler
3.1 Sınıf Hiyerarşisi

personel
   ├── akademik
             ├── professor
             ├── docent
             ├── drogruyesi
             └── arasgor
    ├── idari
           ├── memur
           └── teknikPersonel

4. Değerlendirme Ölçütleri

| Kriter                                       | Puan |
|----------------------------------------------|------|
| Ders içinde görülen konuların uygulanması   | 40   |
| Yorumlarla açıklayıcılık ve dökümantayon    | 15   |
| Fonksiyon işlevselliği                       | 25   |
| Kod kalitesi                                 | 20   |
| **Toplam:**                                  | **100** |

5. Teslim Şekli

Ödevin 4 Haziran 2025 23:00 tarihine kadar online.deu.edu.tr adresinden iletilmesi istenmektedir.

Ödev kodlarınız ile beraber proje dökümanı yüklemeniz beklenmektedir.

Öğrenci numaranız içinde dosyaları sıkıştırarak (örneğin 2016800648.rar) dosyalarınızı sisteme yükleyebilirsiniz. Proje dokümanınızda kapak sayfası, öğrenci bilgileriniz ve kodlarınızı açıklamanız beklenmektedir. Yüklenen kod içinde kodlar ve dokümantasyon adında iki klasör içinde istenen dosyaları bulundurunuz.

Ödev yüklemesinin geciktirildiği her gün için puanınız 10 puan düşülecektir.

Herhangi bir sorunuz için muhammet.damar@deu.edu.tr adresine mail atabilir veya hocanız ile iletişime geçebilirsiniz.

Başarılar dileriz.