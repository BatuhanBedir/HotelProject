
CORS, bir web tarayicisinin bir kaynaktan (ornegin, bir API) diger bir kaynaga ornegin, bir web sitesi) yapilan isteklerin 

guvenlik nedenleriyle kisitlandigi bir mekanizmadir.

**builder.Services.AddCors(opt => { ... })** -> rojedeki hizmet koleksiyonuna CORS yapilandirmasini eklemek icin kullanilir. 
"builder" genellikle "IServiceCollection" nesnesini ifade eder ve projedeki hizmetlerin kaydedildigi koleksiyondur.

**opt.AddPolicy("OtelApiCors", opts => { ... })** -> CORS politikasi eklemek icin kullanilir. Politika, belirli bir adla 
tanimlanir ve daha sonra bu adi kullanarak istegin kaynaktan gelen veya hedefe giden alan adlarini eslestirmek icin 
kullanilabilir.

**opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()** -> Olusturulan politikaya izinler ekler. AllowAnyOrigin()" tum 
kaynaklardan gelen isteklere izin verir, "AllowAnyHeader()" tum HTTP basliklarina izin verir ve "AllowAnyMethod()" tum HTTP 
metodlarina (GET, POST, PUT, DELETE vb.) izin verir. Bu kombinasyon, CORS kisitlamalarinin tamamen kaldirildiði anlamina gelir
 ve API'nin herhangi bir kaynaktan ve her turlu isteðe acik olduðu anlamina gelir.
