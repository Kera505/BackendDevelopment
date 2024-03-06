# Static acarsozu ve static constructor

### Static
***
> Static (ing. sabit) access modifier (ing. elcatma modifikatoru) class, property, method, operator, event ve constructor ile birge istifade edile biler. Ayriliqda aciqlayaq :

- **Egər yaradacağımız class birdən çox yerdə istifadə azad istifadə etmək istəyirikə o static ola bilər. Məsələn, yaratdığımız Üçbucaq sinifini sabit elan edərək onun içərisindəki metodları azad şəkildə çağırıb istifadə edə bilərik. Və ya əvvəlki məqalədən gördüyümüz digər nümunəyə baxaq, “using static System.Console” yazaraq “System.Consol”-u static elan edə və içərisindəki metodu statik kimi çağıra bilərik. Məsələn: “WriteLine();”.**

**Əgər bir class static elan edildisə onun içərisinə daxil olan bütün method, property və field-lər də static yazılmalıdır. İstifadəsini isə “Writeline();” metodunun misalında gördük.**

**Operatorları yəqin ki, hamımız tanıyırıq: “+”, “-”, “>”, “>=”, “++”, “==” və b. Əlbəttə operatorlar statik yaradılmasaydı onları istədiyimiz yerdə azad şəkildə çağıra bilməzdik, əvvəlcə daxil olduğu sinif və adsahəsini yazmalı olacaqdıq, və bu çox eybəcər görünərdi****

### Events
***
> Events — (ing. hadisələr) class və ya object-i abunə olduğu hadisə haqqında xəbərdar etmək üçündür.

- **Hadisəni göndərən və ya başladan class publisher (ing. elan edən) adlanır. Hadisəni qəbul edən və ya handle edən (ing. emal edən) class isə subscriber (ing. abunə olan) adlanır. Bunlar sadəcə Event-ləri başa düşməyimiz üçündür. Bu barədə çox danışmayacam amma başa düşməyiniz lazım olan Event class-ının da operatorlar kimi sistem tərəfindən defolt olaraq static elan edilməsidir.**

### Static Constructor
***
> Static constructor haddında bir neçə əsas məsələni sadalamaq istəyirəm. Bunlar yadda saxlanması vacib olanlardır.

- **Static constructor yalnız bir ədəd təyin oluna bilər. Overload oluna bilməz.**
- **Heç bir parametr qəbul edə bilməz.**
- **Birbaşa çağırıla bilməz.**

 - **Static constructor yalnız birinci dəfə class-ın objecti yaradıldıqda işə düşür. Ümumiyyətlə bir sinifin obyektini yaradırıqsa ilk olaraq onun statik xüsusiyyətləri yaradılır, daha sonra statik konstruktoru işə düşür.**
