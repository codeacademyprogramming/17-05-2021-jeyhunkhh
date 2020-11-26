class Car{
    constructor(fuelUsage,fuelCapacity){
        this.fuelUsage = fuelUsage;
        this.fuelCapacity = fuelCapacity;
        this.currentFuel = 0;
        this.localKm = 0;
        this.globalKm = 0;
    }

    drive(km){
        if (km * this.fuelUsage / 100 > this.currentFuel) {
            console.log("Cari yanacaqla bu qədər yolu gedə bilməzsiniz");
            return;
        }

        this.currentFuel -= km * this.fuelUsage / 100;
        this.localKm += km;
        this.globalKm += km;

        console.log(`${km} km maşın sürüldü, cari yanacaq : ${this.currentFuel} litrdir`);
    }

    addFuel(litr){
        if (litr + this.currentFuel > this.fuelCapacity) {
            console.log("Bu qədər yanacaq əlavə edə bilməzsiniz")
            return;
        }

        this.currentFuel += litr;
        console.log(`${litr} litr yanacaq əlavə olundu, cari yanacaq : ${this.currentFuel} litrdir`);
    }

    resetLocalKm() {
        this.localKm = 0;
        console.log("Maşının localkm-i sıfırlandı");
    }
}

let c180 = new Car(11,45);
c180.addFuel(20);
c180.drive(20)
c180.addFuel(30);

console.log(c180);

let a4 = new Car(13,50);
a4.addFuel(30);
a4.drive(50);
a4.resetLocalKm();

console.log(a4);
