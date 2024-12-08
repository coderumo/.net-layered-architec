# **RABackend Projesi**

Bu proje, Engin Demiroğ tarafından öğretilen bilgiler doğrultusunda, modern yazılım geliştirme prensiplerini uygulayarak .NET teknolojileriyle oluşturulmuş bir **backend** uygulamasıdır.

Proje kapsamında aşağıdaki teknolojiler ve yaklaşımlar kullanılmaktadır:

---

## **Kullanılan Teknolojiler ve Mimariler**

### **Entity Framework Core**
Veritabanı işlemlerini yönetmek ve veri erişim katmanını oluşturmak için kullanılmıştır.

### **Katmanlı Mimari**
Uygulamanın modüler ve sürdürülebilir olmasını sağlamak amacıyla farklı katmanlar oluşturulmuştur:

- **Entities Katmanı**: Veri modelleri ve veritabanı ile ilişkili sınıflar.
- **DataAccess Katmanı**: Veritabanı işlemlerini yöneten katman.
- **Business Katmanı**: İş kurallarının yazıldığı ve uygulama mantığının bulunduğu katman.
- **WebAPI Katmanı**: Uygulamanın dış dünyaya açılan kapısı.

### **JWT (JSON Web Token)**
Kullanıcı kimlik doğrulama ve yetkilendirme işlemleri için kullanılmıştır.

### **Dependency Injection (Autofac)**
Bağımlılık yönetimini sağlamak ve uygulamanın test edilebilirliğini artırmak için Autofac kütüphanesi entegre edilmiştir.

---

## **Öne Çıkan Özellikler**

### **Kimlik Doğrulama ve Yetkilendirme**
- JWT kullanılarak kullanıcıların kimlik doğrulaması ve erişim yetkileri yönetilmektedir.

### **Katmanlı Yapı**
- Katmanlı mimari, proje geliştirme ve yönetimi sırasında kolaylık sağlamaktadır.

### **Esnek Bağımlılık Yönetimi**
- Autofac kütüphanesi sayesinde modüler bir yapı sağlanmıştır.

### **Veritabanı İşlemleri**
- Entity Framework Core kullanılarak Code First yaklaşımı uygulanmıştır.


