# Javascript Syntax (Söz Dizimi)
* Javascript'te komut oluşturrabilmek için yazdığımız kod cümlelerine ifade (statement) denir.
* İfadeler birbirinden ";" işareti ile ayrılır.
* Ancak Js'te ifadelerin sonuna ";" koymak zorunlu değildir.
* Her ne kadar zorunlu olmasa da ifadelerin sonuna ";" işareti konulmasına dikkat edilmeli. Karmaşık kodlarda hata verirse bulması zor olabilir.
*  [ECMAScript Automatic Semicolumn Insertion detaylı bilgi](https://tc39.es/ecma262/multipage/ecmascript-language-lexical-grammar.html)
* Tanımlıyıcıların isimlendirilmesi ile ilgili hususlar:
    * Tanımlayıcı(değişken fonksiyon vb.) adları "_", "$" ve harf ile başlayabilir. Yani "_", "$" hariç özel karakter yada rakamla başlayamaz.
    * Tanımlayıcı adları küçük/BÜYÜK harf duyarlıdır!
    * İSİMLENDİRME YAPARKEN TÜRKÇE KARAKTER KULLANMA!
    * Tanımlayıcı isimlendirme yöntemleri
        * CamelCase:
        En çok kullanılan isimlendirme tekniklerinden biridir.Sözcüklerin ilk harfi büyük, geri kalanlar küçük yazılır. İki kullanım şekli var:
            * Upper Camel Case: Pascal Case de denir. Bu yöntemde gerçekten de sözcüklerin ilk harfi büyük, geri kalanlar küçüktür. Ör: FirstName, DugumTarihi, GirisSarti, IseBaslamaTarihi.
            * Lower Camle Case: Genellikle Camel Case dendiğinde akla bu gelir. İlk sözcük tamamen küçük, geri kalan sözcükler Upper Camel Case kuralı ile yazılır. Ör: firstName, dogumTarihi, girisSarti, iseBaslamaTarihi.
        * Snake Case: Sözcüklerin birbirinden "_" işareti ile ayrılarak yazıldığı tekniktir. Üç tekniği var:
            * Upper Snake Case: FIRST_NAME DOGUM_TARIHI GIRIS_SAATI ISE_BASLAMA_TARIHI
            * Lower Snake Case: first_name, dogum_tarihi, giris_saati, ise_baslama_tarihi.
            * Screamin Snake Case: First_Name, Dogum_Tarihi, Giris_Saati, Ise_Baslama_Tarihi.
    * Javascript'te isimlendirme teknikleri:
        * Değişkenler:
            * Büyük küçük harf duyarlı
            * camelCase tekniği kullanılır.
            * Değişken içerdiği değeri tanımlayacak şekilde bir isme sahip olmalıdır.
            * Mantıksal(boolean) değişkenlere isim verirken is, has gibi ifadelerle başlamasına dikkat edilmelidir.
            * Mümkün olduğu kadar ingilizce kavramlarla isimlendirme yapılmalıdır.
        * Fonksiyonlar:
            * Büyük küçük harf duyarlı.
            * camelCase tekniği kullanılır.
            * Fonksiyonlara isim verirken get, make, apply gibi emir kipi içeren ifadelerle başlanmalıdır.