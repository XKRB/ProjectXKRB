using API.General.InputOutputStructures.Products;
using API.Models;
using API.Repositories.Interfaces;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Services.Clases
{
    public class ProductService /*: IProductService*/
    {
        private ProductModel _product = null;

        /// <summary>
        /// To manage products's table data
        /// </summary>
        private readonly IProductRepository _productRepository;

        /// <summary>
        /// Parameters are passed via dependency injection to manage tables data
        /// </summary>
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        /// <summary>
        /// Get product
        /// </summary>
        /// <param name="idProduct"> product id </param>
        /// <returns> product id, product name and product price </returns>
        public async Task<GetProductOutput> IGetProduct(int idProduct)
        {
            ProductModel product = await _productRepository.GetProduct(idProduct);

            GetProductOutput productOutput = new GetProductOutput() { IdProduct = product.IdProduct };

            return productOutput;
        }

        /// <summary>
        /// Create product
        /// </summary>
        /// <param name="cretateProduct"> CreateProductInput object </param>
        public async Task<ProductModel> CreateProduct(CreateProductInput createProduct)
        {
            _product = new ProductModel(createProduct.IdProduct, createProduct.ProductName, createProduct.ProductPrice);

            _product = await _productRepository.CreateProduct(_product);

            return _product;
        }

        /// <summary>
        /// Update product
        /// </summary>
        /// <param name="updateProduct"> name and email </param>
        /// <returns> Task </returns>
        public async Task IUpdateProduct(UpdateProductInput updateProduct)
        {
            _product = await _productRepository.GetProduct(updateProduct.IdProduct);

            _product.IdProduct = updateProduct.IdProduct;
            _product.ProductName = updateProduct.ProductName;
            _product.ProductPrice = updateProduct.ProductPrice;

            _product = await _productRepository.UpdateProduct(_product);
        }

        /// <summary>
        /// Delete product permanently
        /// </summary>
        /// <param name="userName">User name</param>
        public async Task IDeleteProduct(int idProduct)
        {
            ProductModel product = await _productRepository.GetProduct(idProduct);
            //_product.IdProduct = idProduct;

            await _productRepository.DeleteUser(product);

        }
        //public async Task<GetProductOutput> IGetProduct(int idProduct)
        //{
        //    ProductModel product = await _productRepository.GetProduct(idProduct);

        //    GetProductOutput productOutput = new GetProductOutput() { IdProduct = product.IdProduct };

        //    return productOutput;
        //}
    }
}
