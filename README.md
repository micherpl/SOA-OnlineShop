# SOA-OnlineShop

API:  
GET:   
kupowanie: http://localhost:50836/api/buying/{id}/{count}/{username}/{password} zwraca: string z komunikatem  
listowanie wszystkich produktów: http://localhost:50836/api/getAllProducts/ zwraca: liste produktów w jsonie  
listowanie wszystkich uzytkowników: http://localhost:50836/api/GetAllUsers/ zwraca: liste userow w jsonie

POST:  
rejestracja: http://localhost:50836/api/RegisterUser/ header: Content-Type: application/json Body: uzytkownik (json)  
    zwraca: uzytkownik (json) lub null jak istnieje lub sie cos nie udalo

DELETE:  
kasowanie uzytkownika: http://localhost:50836/api/UnRegister/{username} zwraca: bool
