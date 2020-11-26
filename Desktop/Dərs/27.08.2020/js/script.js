let gun = {
    currentPistol : 0,  //daraq
    pistonCapacity : 30,  // daraq tutumu
    pistonCount : 100,    // umumi gulle sayi

    shoot: function (count) {
        if( count > this.currentPistol ){
            console.log("silahda kifayet qeder gulle yoxdu");
            return;
        }
        
        this.currentPistol -= count;
        console.log(`${this.currentPistol} eded gulle qaldi`)
    },
            
}


gun.shoot(25);

