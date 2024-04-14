using CarStore.Data;
using CarStore.Models;
using CarStore.ViewModels;

namespace CarStore.Services
{
    public class CarService
    {
        private AppDbContext _appDbContext;
        private readonly string wwwRootPath;
        public CarService(AppDbContext appDBContext, IWebHostEnvironment hostEnvironment)
        {
            _appDbContext = appDBContext;
            wwwRootPath = hostEnvironment.WebRootPath;
        }
        public void AddCar(Car ToAdd)
        {
            string fileName = Path.GetFileNameWithoutExtension(ToAdd.FormFile.FileName);
            string extension = Path.GetExtension(ToAdd.FormFile.FileName);
            ToAdd.Path = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/Images/", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                ToAdd.FormFile.CopyTo(fileStream);
            }
            _appDbContext.Cars.Add(ToAdd);
            _appDbContext.SaveChanges();
        }
        public void AddProducer(Producer ToAdd)
        {
            _appDbContext.Producers.Add(ToAdd);
            _appDbContext.SaveChanges();
        }
        public List<Producer> GetAllProducers()
        {
            return _appDbContext.Producers.ToList();
        }
        public List<Car> GetAllCars()
        {
            return _appDbContext.Cars.ToList();
        }
        public Car GetCar(Guid id)
        {
            var car = _appDbContext.Cars.Where(x => x.ID == id).FirstOrDefault();
            return car!;
        }
        public Producer GetProducer(Guid id)
        {
            var producer = _appDbContext.Producers.Where(x => x.ProdID == id).FirstOrDefault();
            return producer!;
        }
        internal void DeleteCar(Guid id)
        {
            var car = _appDbContext.Cars.Where(x => x.ID == id).FirstOrDefault()!;
            if (car == null)
                throw new Exception("Image was not found");
            var filePath = Path.Combine(wwwRootPath + "/Images/", car.Path);

            if (System.IO.File.Exists(filePath))
                System.IO.File.Delete(filePath);

            _appDbContext.Cars.Remove(car);
            _appDbContext.SaveChanges();
        }
        internal void DeleteProducer(Guid id)
        {
            var prod = _appDbContext.Producers.Where(x => x.ProdID == id).FirstOrDefault();
            if (prod == null)
            {
                throw new Exception("Producator invalid");
            }
            var carsToRem = _appDbContext.Cars.Where(x => x.ProdID == id).ToList();
            _appDbContext.Cars.RemoveRange(carsToRem);
            _appDbContext.Producers.Remove(prod);
            _appDbContext.SaveChanges();
        }
        internal void UpdateCar(Car car)
        {
            var carToUpdate = _appDbContext.Cars.FirstOrDefault(x => x.ID == car.ID);
            if (carToUpdate == null)
                throw new Exception("Car was not found");
            carToUpdate.Model = car.Model;
            carToUpdate.Price = car.Price;
            carToUpdate.CapacitateaMotorului = car.CapacitateaMotorului;
            carToUpdate.TipulCombustibilului = car.TipulCombustibilului;
            carToUpdate.Transmisie = car.Transmisie;
            carToUpdate.TipTractiune = car.TipTractiune;
            carToUpdate.NumarUsi = car.NumarUsi;
            carToUpdate.NumarLocuri = car.NumarLocuri;
            carToUpdate.ProdID = car.ProdID;

            _appDbContext.SaveChanges();
        }
        internal void UpdateProducer(Producer prod)
        {
            var producerToUpdate = _appDbContext.Producers.FirstOrDefault(x => x.ProdID == prod.ProdID);
            if (producerToUpdate == null)
                throw new Exception("Producer was not found");
            producerToUpdate.ProdID = prod.ProdID;
            producerToUpdate.Denumire = prod.Denumire;
            producerToUpdate.Adresa = prod.Adresa;

            _appDbContext.SaveChanges();
        }
    }
}
