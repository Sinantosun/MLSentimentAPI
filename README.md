# ML.NET Sentiment Analysis API

Bu proje, C# ve ML.NET kütüphanesi kullanılarak geliştirilmiş basit bir metin duygu analizi (Sentiment Analysis) Web API uygulamasıdır. Kullanıcıdan gelen yorumları analiz ederek olumlu, olumsuz veya nötr olarak sınıflandırır.

## Özellikler

- **ML.NET**: Makine öğrenmesi modeli tamamen .NET ekosistemi içinde eğitilmiştir.
- **Multiclass Classification**: Üç farklı duygu sınıfını ayırt edebilir.
- **Singleton PredictionEngine**: Yüksek performanslı tahminler için optimize edilmiştir.
- **REST API**: ASP.NET Core Web API ile dış dünyaya açılmıştır.

## Kurulum

1. **Clone**:  
git clone https://github.com/kullanici-adin/proje-adin.git

2. **Bağımlılıkların Yüklenmesi**:  
dotnet restore

## Kullanım

API'ye bir POST isteği göndererek analiz yapabilirsiniz:

- **Endpoint**: `POST /api/sentiment/predict`
- **İstek (JSON)**:
{
"text": "Bu ürün gerçekten harika!"
}

- **Yanıt (JSON)**:
{
"sonuc": "olumlu"
}

## Blog Yazısı

Bu projenin adım adım yapılışını anlattığım blog yazısına buradan ulaşabilirsiniz:  

https://sinantosun.com/blog-detayi/dotnet-mlnet-metin-duygu-analizi
