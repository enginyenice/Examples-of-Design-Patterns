
# Singleton
Herhangi bir sınıf türünde birçok kez nesne örneği yaratılmak istenebilir.Söz konusu sınıf nesnesinin sadece bir kereliğine yaratılıp daha sonra sürekli olarak kendisinin kullanılması isteniyor olabilir. İşte bu ihtiyacı karşılayan tasarım çözümünün ismi Singleton patern'idir.

## Multi Thread Signleton Pattern
Singleton pattern tek thread'lı uygulamalarda sorunsuz çalışabilirken birden çok thread'ın çalıştığı uygulamalarda nesnenin tek bir örneğinin yaratılacağı garanti edilemez. Farklı threadlarda bu uygulanmış olmasına rağmen farklı nesne örnekleri yaratılmış olabilir. Bunu engellemek için thread senkronizasyon mekanizmalarından yararlanılmalıdır. Bu noktada C# programlama dilinde **lock** kullanılabilir.

```C#
lock(entity){

}
```

## Volatile
Birden fazla mikroişlemcinin (cpu) olduğu sistemlerde veya çok çekirdekli sistemlerde Singleton pattern'i yoluyla tekil bir nesne yaratma işlemini garantilemek için volatile anahtar sözcüğü kullanılabilir.

C# dilinde volatile anahtar sözcüğü özellikle multithread uygulamalarda kritiktir. Volatile anahtar sözcüğü ile tanımlanan bir değerinin değerini aynı anda başka bir thread'ın değiştirebilmesi imkansızdır. Singleton pattern'inde tekilliği garantilemek için kullanılır

```C#
private static volatile VolatileSample mp_Smp;
```
