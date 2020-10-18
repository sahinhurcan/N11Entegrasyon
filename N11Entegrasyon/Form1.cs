using N11Entegrasyon.UrunServis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using N11Entegrasyon;

namespace N11Entegrasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                        

        }
        //public void ApiBilgisi()
        //{
        //    Authentication auth = new Authentication();
        //    auth.appKey = "7094ef60-aa6d-4eed-ba67-9c7c0665eceb";
        //    auth.appSecret = "QBKFaVBCC2jCLC1f";
        //}

        private void button1_Click(object sender, EventArgs e)
        {

            //DeleteProductByIdRequest urunsil = new DeleteProductByIdRequest();
            //Authentication auth = new Authentication();
            //auth.appKey = "7094ef60-aa6d-4eed-ba67-9c7c0665eceb";
            //auth.appSecret = "QBKFaVBCC2jCLC1f";
            //urunsil.auth = auth;
            //urunsil.productId = 436061583;

            var auth = new Authentication();
            auth.appKey = "7094ef60-aa6d-4eed-ba67-9c7c0665eceb"; //api anahtarınız
            auth.appSecret = "QBKFaVBCC2jCLC1f"; ;//api şifeniz

            ProductServicePortService silPort = new ProductServicePortService();
            DeleteProductByIdRequest request = new DeleteProductByIdRequest();
            request.auth = auth;
            request.productId = 436273013;


            DeleteProductByIdResponse response = new DeleteProductByIdResponse();
            var result = silPort.DeleteProductById(request);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //var auth = new Authentication();
            //auth.appKey = "7094ef60-aa6d-4eed-ba67-9c7c0665eceb"; //api anahtarınız
            //auth.appSecret = "QBKFaVBCC2jCLC1f"; ;//api şifeniz

            //ProductServicePortService proxy = new ProductServicePortService();
            
            //request.auth = auth;
            //request.productId = 436061583;


            //GetProductByProductIdResponse response = new GetProductByProductIdResponse();
            //var result = proxy.DeleteProductById(request);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
            var auth = new Authentication();
            auth.appKey = "API-KEY"; //api anahtarınız
            auth.appSecret = "API-SIFRE"; ;//api şifeniz

            ProductServicePortService prodServ = new ProductServicePortService();

            SaveProductRequest saveRequest = new SaveProductRequest();
            //request.auth = auth;
            //request.productId = "436061583";
            saveRequest.product.productSellerCode = "5555";
            saveRequest.product.title = "TEST YAZILIM ÜRÜNÜ";
            saveRequest.product.subtitle = "1 Ay Ürünümüzü Test Edin";
            saveRequest.product.description = " 1 aylık demo kurulum lisansıdır.mağazamızdan sınırsız lisans da alabilirsiniz";
            saveRequest.product.category.id = 1000320;
            //saveRequest.product.price =  4.99;
            saveRequest.product.currencyType = "TL";
            //ProductImage UrunGorsel = new ProductImage();
            //UrunGorsel.url = "https://n11scdn.akamaized.net/a1/1024/elektronik/ofis-programlari/teknik-serv-is-programi__0216739852896260.jpg";
            //saveRequest.product.images.image.url = UrunGorsel;
            //saveRequest.product.images.image.order = "0";
            saveRequest.product.productCondition = "1";
            saveRequest.product.preparingDay = "2";
            saveRequest.product.shipmentTemplate = "ucretsiz";


            //request.product.stockItems.stockItem.quantity = 3;

            //var result = proxy.SaveProductRequest(request);
            SaveProductResponse saveResponse = prodServ.SaveProduct(saveRequest);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var auth = new Authentication();
            auth.appKey = "API-KEY"; //api anahtarınız
            auth.appSecret = "API-SIFRE"; ;//api şifeniz

            ProductServicePortService silPort = new ProductServicePortService();
            DeleteProductBySellerCodeRequest UrunSil = new DeleteProductBySellerCodeRequest();
            UrunSil.auth = auth;
            UrunSil.productSellerCode = "5555";

            DeleteProductBySellerCodeResponse response = new DeleteProductBySellerCodeResponse();
            var result = silPort.DeleteProductBySellerCode(UrunSil);

            //-----------------------------------------------------------//
            /*
            var auth = new Authentication();
            auth.appKey = "7094ef60-aa6d-4eed-ba67-9c7c0665eceb"; //api anahtarınız
            auth.appSecret = "QBKFaVBCC2jCLC1f"; ;//api şifeniz

            ProductServicePortService silPort = new ProductServicePortService();
            DeleteProductByIdRequest request = new DeleteProductByIdRequest();
            request.auth = auth;
            request.productId = 436273013;


            DeleteProductByIdResponse response = new DeleteProductByIdResponse();
            var result = silPort.DeleteProductById(request);
            */


        }
    }
}
