﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gateway.ProductServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/ProductDatabase")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float PriceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Count {
            get {
                return this.CountField;
            }
            set {
                if ((this.CountField.Equals(value) != true)) {
                    this.CountField = value;
                    this.RaisePropertyChanged("Count");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductServiceReference.IProductService")]
    public interface IProductService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetProduct", ReplyAction="http://tempuri.org/IProductService/GetProductResponse")]
        Gateway.ProductServiceReference.Product GetProduct(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetProduct", ReplyAction="http://tempuri.org/IProductService/GetProductResponse")]
        System.Threading.Tasks.Task<Gateway.ProductServiceReference.Product> GetProductAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/DeleteProduct", ReplyAction="http://tempuri.org/IProductService/DeleteProductResponse")]
        bool DeleteProduct(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/DeleteProduct", ReplyAction="http://tempuri.org/IProductService/DeleteProductResponse")]
        System.Threading.Tasks.Task<bool> DeleteProductAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetAllProducts", ReplyAction="http://tempuri.org/IProductService/GetAllProductsResponse")]
        Gateway.ProductServiceReference.Product[] GetAllProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetAllProducts", ReplyAction="http://tempuri.org/IProductService/GetAllProductsResponse")]
        System.Threading.Tasks.Task<Gateway.ProductServiceReference.Product[]> GetAllProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/UpdateProduct", ReplyAction="http://tempuri.org/IProductService/UpdateProductResponse")]
        Gateway.ProductServiceReference.Product UpdateProduct(Gateway.ProductServiceReference.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/UpdateProduct", ReplyAction="http://tempuri.org/IProductService/UpdateProductResponse")]
        System.Threading.Tasks.Task<Gateway.ProductServiceReference.Product> UpdateProductAsync(Gateway.ProductServiceReference.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/AddProduct", ReplyAction="http://tempuri.org/IProductService/AddProductResponse")]
        int AddProduct(Gateway.ProductServiceReference.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/AddProduct", ReplyAction="http://tempuri.org/IProductService/AddProductResponse")]
        System.Threading.Tasks.Task<int> AddProductAsync(Gateway.ProductServiceReference.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/DecreaseProductCount", ReplyAction="http://tempuri.org/IProductService/DecreaseProductCountResponse")]
        bool DecreaseProductCount(int id, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/DecreaseProductCount", ReplyAction="http://tempuri.org/IProductService/DecreaseProductCountResponse")]
        System.Threading.Tasks.Task<bool> DecreaseProductCountAsync(int id, int count);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductServiceChannel : Gateway.ProductServiceReference.IProductService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductServiceClient : System.ServiceModel.ClientBase<Gateway.ProductServiceReference.IProductService>, Gateway.ProductServiceReference.IProductService {
        
        public ProductServiceClient() {
        }
        
        public ProductServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Gateway.ProductServiceReference.Product GetProduct(int id) {
            return base.Channel.GetProduct(id);
        }
        
        public System.Threading.Tasks.Task<Gateway.ProductServiceReference.Product> GetProductAsync(int id) {
            return base.Channel.GetProductAsync(id);
        }
        
        public bool DeleteProduct(int id) {
            return base.Channel.DeleteProduct(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteProductAsync(int id) {
            return base.Channel.DeleteProductAsync(id);
        }
        
        public Gateway.ProductServiceReference.Product[] GetAllProducts() {
            return base.Channel.GetAllProducts();
        }
        
        public System.Threading.Tasks.Task<Gateway.ProductServiceReference.Product[]> GetAllProductsAsync() {
            return base.Channel.GetAllProductsAsync();
        }
        
        public Gateway.ProductServiceReference.Product UpdateProduct(Gateway.ProductServiceReference.Product product) {
            return base.Channel.UpdateProduct(product);
        }
        
        public System.Threading.Tasks.Task<Gateway.ProductServiceReference.Product> UpdateProductAsync(Gateway.ProductServiceReference.Product product) {
            return base.Channel.UpdateProductAsync(product);
        }
        
        public int AddProduct(Gateway.ProductServiceReference.Product product) {
            return base.Channel.AddProduct(product);
        }
        
        public System.Threading.Tasks.Task<int> AddProductAsync(Gateway.ProductServiceReference.Product product) {
            return base.Channel.AddProductAsync(product);
        }
        
        public bool DecreaseProductCount(int id, int count) {
            return base.Channel.DecreaseProductCount(id, count);
        }
        
        public System.Threading.Tasks.Task<bool> DecreaseProductCountAsync(int id, int count) {
            return base.Channel.DecreaseProductCountAsync(id, count);
        }
    }
}
