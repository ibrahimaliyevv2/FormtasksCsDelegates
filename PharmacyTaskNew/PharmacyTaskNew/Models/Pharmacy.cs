using System;
using System.Collections.Generic;
using System.Text;
using PharmacyTaskNew.Exceptions;

namespace PharmacyTaskNew.Models
{
    public class Pharmacy
    {
        public int MedicineLimit { get; set; }
        public Pharmacy(int medicineLimit)
        {
            MedicineLimit = medicineLimit;
        }


        List<Medicine> Medicines = new List<Medicine>();
        public void AddMedicine(Medicine medicine)
        {
            if (Medicines.Count <= MedicineLimit)
            {

                if (!Medicines.Exists(b => b.Name == medicine.Name))
                {
                    Medicines.Add(medicine);
                }
                else
                {
                    throw new MedicineAlreadyExistsException("bu adda derman var!");
                }
            }
            else
            {
                throw new CapacityLimitException("Yer yoxdur!");
            }
        }

        public List<Medicine> GetAllMedicines()
        {
            List<Medicine> CopyMedicines = new List<Medicine>();
            CopyMedicines.AddRange(Medicines.FindAll(x => x.IsDeleted == false));
            return CopyMedicines;
        }

        public List<Medicine> FilterMedicineByPrice(double minPrice, double maxPrice)
        {
            return Medicines.FindAll(x => x.Price > minPrice && x.Price < maxPrice);
        }

        public Medicine GetMedicineById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Null!");
            }
            return Medicines.Find(x => x.Id == id && x.IsDeleted == false);
        }

        public void DeleteMedicineById(int? id)
        {
            if (id != null)
            {
                if (!Medicines.Exists(x => x.Id == id && x.IsDeleted == false))
                {
                    throw new NotFoundException("Bele bir derman tapilmadi");
                }
                else
                {
                    Medicines.Find(x => x.Id == id && x.IsDeleted == false).IsDeleted = true;
                }
            }
            else {
                throw new NullReferenceException("Null!");
            }
        }

        public void EditMedicineEmail(int? id, string name)
        {

            if (id == null || string.IsNullOrWhiteSpace(name))
            {
                throw new NullReferenceException();
            }
            if (!Medicines.Exists(x => x.Id == id && x.IsDeleted == false))
            {
                throw new NotFoundException("Bele bir derman tapilmadi");
            }
            else
                Medicines.Find(x => x.Id == id && x.IsDeleted == false).Name = name;
        }

    }
}
