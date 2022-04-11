# FormtasksCsDelegates

Task-1:

Aşağıdakı custom exceptionları yaradın:
- CapacityLimitException
- MedicineAlreadyExistsException
- NotFoundException


Medicine class

- Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq və hər dəfə yeni bir Medicine
  obyekt yaradıldıqda avtomatik bir vahid artacaq.
- Name
- Price
- Count
- IsDeleted - dərmanın silinib silinmədiyini göstərəcək true/false, default olaraq
false olacaq.
- Sell() - bu method işə düşdükdə count bir vahid azalacaq.
- ShowInfo()-melumatlari geri qaytarir.





Pharmacy class

- MedicineLimit
- Medicines - List of Medicine

- AddMedicine() - parametr olaraq bir Medicine obyekti qəbul edəcək və list-ə əlavə edəcək əgər əlavə olunan adda bir
Medicine obyekti varsa listdə MedicineAlreadyExistsException qaytaracaq daha sonra əgər limit aşılarsa CapacityLimitException baş verəcək.

- GetAllMedicines() -
Medicines listinin kopyasını geriyə qaytaracaq və medicines list içindəki medicine obyektlərinin isDeleted dəyəri false olmalıdır .


- FilterMedicinesByPrice() - parametr olaraq bir minPrice birdə maxPrice qəbul edəcək və method daxilində həmin aralıqda qiyməti olan medicine obyektlərini tapıb geriyə qaytaracaq.

- GetMedicineById() - parametr olaraq nullable int tipindən bir id qəbul edəcək əgər id null olarsa NullReferenceException qaytaracaq əks halda həmin id-li və isDeleted statusu
 false olan Medicine obyektini tapıb geriyə qaytaracaq.


- DeleteMedicineById() - parametr olaraq nullable int tipindən bir id qəbul edəcək əgər id null olarsa NullReferenceException qaytaracaq
əks halda həmin id-li və isDeleted dəyəri false olan Medicine obyektini axtaracaq əgər elə bir medicine obyekti tapılmasa geriyə NotFoundException
 qaytaracaq tapıldığı təqdirdə isə həmin medicine obyektinin isDeleted statusunu false-dan dəyişib true edəcək amma listdən silinməyəcək həmin obyekt sadəcə statusu dəyişib true olacaq.

- EditMedicineEmail() - parametr olaraq nullable int tipindən bir id və string tipindən bir name dəyəri qəbul edəcək əgər id və ya
name null olarsa NullReferenceException qaytaracaq əks halda həmin id-li və isDeleted dəyəri false olan medicine obyektini axtaracaq əgər elə bir medicine obyekti tapılmasa geriyə NotFoundException
 qaytaracaq tapıldığı təqdirdə isə həmin medicine obyektinin name dəyərini dəyişəcək.

ps: MedicineLimit olmadan Pharmacy obyekti yaratmaq olmaz və methodlar daxilində List-in methodlarından istifadə edin.
