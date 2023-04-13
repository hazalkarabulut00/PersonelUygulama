using PersonelUygulama.Models;

namespace PersonelUygulama.Data
{
    public class PersonelServis
    {
        private readonly PersonelContext _context;

        public PersonelServis(PersonelContext context)
        {
            _context = context;
        }
        public List<Personeller> PersonelleriGetir()
        {
            return _context.Personellers.ToList();
        }
        public void PersonelEkle(Personeller personel) 
        { 
            s
            _context.Personellers.Add(personel);
            _context.SaveChanges();
        }
        public void PersonelSil(Personeller personel)
        {
            _context.Personellers.Remove(personel);
            _context.SaveChanges();
        }

        public void PersonelBilgisiGuncelle(List<Personeller> personeller)
        {
            _context.Personellers.UpdateRange(personeller);
            _context.SaveChanges();
        }

    }
}
