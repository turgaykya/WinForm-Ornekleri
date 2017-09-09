using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Soyutlama
namespace Abstraction
{
    // Abstract(soyut) sınıflar
    // 1. Abstract sınıflardan instance alınamaz (new Keyword'u ile birlikde)
    // 2. Abstract sınıflar miras alındığı takdirde kullanılabilir
    // 3. Abstract sınıftan miras almış sınıfların instance'ı oluşturulabilir

    // Abstract Üyeler
    // 1. Abstract üyeler yalnızca abstract sınıflarda yazılabilir
    // 2. Abstract üyelerin detayları(kodları)(implementation) yoktur.
    // 3. Yalnızca metotlar (+ property) abstract olarak işaretlenebilir
    // 4. Abstract üyeler kesinlikle private olamaz
    // 5. Abstract üyeler mutlaka türetilen sınıf tarafından ezilmek zoruldadır.

    // Virtual üyeler
    // 1. Virtual üyeleri abstract veya normal sınıflarda yazılabilir.
    // 2. Virtual üyelerin varsayılan uyarlaması (kodlaması)(implementation) vardır.
    // 3. Yalnızca metotlar (+ property) virtual olarak işaretlenebilir.
    // 4. Virtual üyeler kesinlikle private olamaz.
    // 5. Virtual üyeler ezilmek zorulda değildir.

    abstract class Vehicle//taşıt (motorlu araç) anlamına geliyor
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Engine { get; set; }
        public Color Color { get; set; }

        //abstract üyeleri ezmek Farz
        public abstract string Start();

        public abstract string Stop();

        // virtual üyeleri ezmek Keyfekeder
        public virtual string Horn()
        {
            return "Düüüt";
        }
    }
}
