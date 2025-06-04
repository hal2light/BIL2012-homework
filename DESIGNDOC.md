# Anadolu Teknoloji Üniversitesi Personel Yönetim Sistemi

## Kapak Sayfası

- **Ders:** BIL2012 - Nesne Yönelimli Programlama
- **Ödev:** 2024-2025 Bahar Dönemi 1. Ödev
- **Öğrenci Adı Soyadı:** [Halit Berken Işık]
- **Öğrenci Numarası:** [2022280097]
- **Teslim Tarihi:** 4 Haziran 2025

---

## 1. Proje Amacı

Bu proje, kalıtım, soyut sınıflar, arayüzler ve çok biçimlilik gibi temel nesne yönelimli programlama kavramlarını gerçekçi bir senaryo üzerinden uygulamayı amaçlamaktadır. Anadolu Teknoloji Üniversitesi'nin akademik ve idari personelinin maaş yönetimi bir konsol uygulaması ile sağlanmaktadır.

---

## 2. Sınıf Diyagramı ve Yapısı

- **Personel (Soyut Sınıf):** Tüm personellerin temel özelliklerini ve maaş hesaplama metodunu içerir.
- **AkademikPersonel (Soyut Sınıf):** Akademik personel için ortak özellikler ve zam uygulama metodu.
- **IdariPersonel (Soyut Sınıf):** İdari personel için ortak özellikler ve zam uygulama metodu.
- **Professor, Docent, DrOgrUyesi, ArasGor:** AkademikPersonel’den türeyen, maaş hesaplaması farklı olan sınıflar.
- **Memur, TeknikPersonel:** IdariPersonel’den türeyen, maaş hesaplaması farklı olan sınıflar.
- **IZamYapilabilir (Arayüz):** Zam uygulama fonksiyonunu zorunlu kılar.
- **PersonelService:** Personel ekleme, zam uygulama, maaş hesaplama ve listeleme işlemlerini yönetir.

---

## 3. Kullanılan Temel Özellikler

- **Kalıtım:** Personel sınıfı temel alınarak diğer personel türleri türetilmiştir.
- **Soyut Sınıf ve Metot:** Personel ve alt sınıflarında soyut metotlar kullanılmıştır.
- **Arayüz:** Zam işlemleri için arayüz kullanılmıştır.
- **Çok Biçimlilik:** Personel listesi üzerinden farklı türde personellerin ortak fonksiyonları çağrılmıştır.

---

## 4. Programın Çalışma Prensibi

- Uygulama başlatıldığında, üniversitede çalışan tüm personeller oluşturulur.
- Her ay için personellerin maaşları hesaplanır ve toplam gider ekrana yazdırılır.
- Haziran ayında akademik ve idari personellere zam uygulanır.
- 12 ay sonunda toplam personel gideri ekrana yazdırılır.

---

## 5. Kod Açıklamaları

Kodlar, `src/Models`, `src/Interfaces`, `src/Services` ve `src/Program.cs` dosyalarında düzenlenmiştir. Her sınıf ve fonksiyonun başında açıklama satırları bulunmaktadır.

---

## 6. Ekran Görüntüsü

```
--- 1. Ay ---
Profesör Onur Polat - Maaş: 230.000 TL
...
Aylık Toplam Personel Gideri: 700.000 TL
...
12 Ay Sonunda Toplam Personel Gideri: 9.000.000 TL
```

---

## 7. Sonuç

Bu proje ile nesne yönelimli programlama prensipleri gerçek bir senaryo üzerinde başarıyla uygulanmıştır. Kodlar ve dokümantasyon klasörler halinde teslim edilmiştir.

---

