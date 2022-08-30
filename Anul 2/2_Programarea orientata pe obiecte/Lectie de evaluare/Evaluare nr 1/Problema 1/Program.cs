using Problema_1;
SmartPhone SmartPhone1= new SmartPhone();
SmartPhone1.Citire();
SmartPhone1.Afisare();
SmartPhone SmartPhone2= new SmartPhone( "Samsung","Galaxy A51",5000);
SmartPhone2.Afisare();
SmartPhone SmartPhone3 = new SmartPhone(SmartPhone1);
SmartPhone3.Afisare();
