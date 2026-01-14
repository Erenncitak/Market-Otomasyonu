# 🏪 Market Otomasyonu (C# WinForms)

Bu proje, **C# Windows Forms** kullanılarak geliştirilmiş, **kamera destekli barkod/karekod okutma** özelliğine sahip bir **Market Otomasyon Sistemi**dir.  
Küçük ve orta ölçekli marketlerde; ürün yönetimi, satış işlemleri ve stok takibini kolaylaştırmak amacıyla hazırlanmıştır.

---

## 🎯 Projenin Amacı

Bu uygulama ile:

- Market ürünleri veritabanında tutulur
- Kasiyer, **kamera ile barkod/karekod okutarak** hızlı satış yapabilir
- Ürünler kategori bazlı (ör. *Meyve & Sebze*) yönetilebilir
- Farklı kullanıcı rolleri için farklı paneller sunulur

Amaç; **gerçek bir market senaryosunu** sade ve anlaşılır bir mimariyle uygulamaktır.

---

## 🧩 Temel Özellikler

### 🔐 Kullanıcı & Rol Yapısı

Projede farklı kullanıcı panelleri bulunmaktadır:

#### 👤 Admin Panel
- Ürün ekleme / güncelleme
- Sistem genel kontrolü

#### 💼 Kasiyer Panel
- Satış işlemleri
- Barkod / karekod okutma

#### 👥 Kullanıcı Panel
- Ürünleri görüntüleme

Bu yapı sayesinde **yetkilendirme mantığı** pratik olarak uygulanmıştır.

---

### 📦 Ürün Yönetimi

- Ürünler **Urun** modeli ile temsil edilir
- Ürün adı, fiyat, barkod gibi bilgiler veritabanında saklanır
- **Repository** yapısı ile veritabanı işlemleri merkezileştirilmiştir

---

## 📷 Barkod / Karekod Okutma Sistemi (Öne Çıkan Özellik)

Bu projede **kamera ile canlı barkod okutma sistemi** bulunmaktadır.

### 🔧 Nasıl Çalışır?

- Bilgisayara bağlı kamera, **AForge.Video.DirectShow** kütüphanesi ile aktif edilir
- Kamera görüntüsü üzerinden barkod/karekod taraması yapılır
- **ZXing.NET** kütüphanesi kullanılarak barkod çözümleme gerçekleştirilir

Okutulan barkod:
- Veritabanındaki ürünle eşleştirilir
- Ürün bilgileri otomatik olarak ekrana getirilir

Okutma başarılı olduğunda:
- Sesli bildirim (**barkod.wav**) çalınır

Bu özellik özellikle **KasiyerPanel** ve **MeyveSebzePanel** içerisinde aktif olarak kullanılmaktadır.  
Manuel ürün arama ihtiyacını ortadan kaldırarak **işlem hızını artırır**.

---

## 🗃️ Veritabanı & Mimari Yapı

Proje, **katmanlı yapıya yakın** bir düzenle hazırlanmıştır:

### Model
- Urun.cs → Ürün verisi

### DAO (Data Access Object)
- Repository.cs → SQL işlemleri

### Controller
- İş kurallarının yönetimi

### UI (WinForms)
- AdminPanel
- KasiyerPanel
- KullaniciPanel
- MeyveSebzePanel
- UrunPanel

Bu yapı, kodun **okunabilirliğini** ve **sürdürülebilirliğini** artırır.

---

## 🛠️ Kullanılan Teknolojiler

- **C#** – Ana programlama dili  
- **Windows Forms** – Masaüstü kullanıcı arayüzü  
- **SQL Server / T-SQL** – Veritabanı işlemleri  
- **AForge.NET** – Kamera erişimi  
- **ZXing.NET** – Barkod / karekod okuma  
- **Visual Studio** – Geliştirme ortamı  

---

## 🚀 Kurulum & Çalıştırma

1. Projeyi klonla  
   git clone https://github.com/Erenncitak/Market-Otomasyonu.git

2. Visual Studio ile `.sln` dosyasını aç  
3. `App.config` içindeki **connection string**’i kendi SQL Server ayarlarına göre düzenle  
4. Gerekli NuGet paketlerini yükle:
   - ZXing.Net
   - AForge.Video
   - AForge.Video.DirectShow
5. Kamerası olan bir bilgisayarda projeyi çalıştır

---

## 🔐 Demo Giriş Bilgileri

Projeyi incelemek isteyenler için örnek kullanıcı hesapları:

### 👤 Admin Panel
- Kullanıcı Adı: **eren**
- Şifre: **111**

### 💼 Kasiyer Panel
- Kullanıcı Adı: **bilal**
- Şifre: **222**

> Bu bilgiler yalnızca **demo amaçlıdır**.  
> Gerçek uygulamalarda şifreler hash’li şekilde saklanmalıdır.

---

## 🧠 Bu Proje Ne Gösteriyor?

Bu proje özellikle şunları kanıtlar:

- C# WinForms ile masaüstü uygulama geliştirme
- SQL veritabanı ile çalışma
- Kamera entegrasyonu
- Barkod / karekod okuma mantığı
- Gerçek hayata uygun senaryo çözümü
- Katmanlı düşünme ve OOP temelleri

Junior pozisyonlar için **uygulamalı proje deneyimi** sunar.

---

## 👤 Geliştirici

**Eren Çıtak**  
GitHub: https://github.com/Erenncitak  

Bu proje öğrenme ve kendimi geliştirme amacıyla hazırlanmıştır.  
Geri bildirim ve önerilere açıktır.
