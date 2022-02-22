using AbstractFactory.AbstractProduct;

namespace AbstractFactory.AbstractFactory
{
    // We declare a set of method that return different abstract item.
    // Every items, in this interface, is a family (concetual term), and they are correlate by a logical.
    // Every item in a family can collaborate toghether but they are incompatible with item in another family.
    public interface IShoe
    {
        IColor GetColor();
        IBrand GetBrand();
    }
}
