using AbstractFactory.Classes;
using AbstractFactory.Interfaces;

// Apple Product

IProductFactory appleFactory = new AppleFactory();
ICellPhone applePhone = appleFactory.GetPhone();
IRouter appleRouter = appleFactory.GetRouter();

applePhone.Call();
appleRouter.Route();

// Huawei Product

IProductFactory huaweiFactory = new HuaweiFactory();
ICellPhone huaweiPhone = huaweiFactory.GetPhone();
IRouter huaweiRouter = huaweiFactory.GetRouter();

huaweiPhone.Call();
huaweiRouter.Route();