
<template>
  <div>

      <HeaderView />
    
             <div class="main_info" ref='content' id="tabalo" >
                
                <div class="payment_info" >
                   
                    <div class="row" >
                        <div class="col-md-12 image">
                        <img  src="../../assets/voyager.png"/>
                        </div>
                    </div>
                     <div class="title row">
                        <center>
                        <h1>
                           hotel- <span class="under_title">Payment Details</span>
                        </h1>
                        </center>
                    </div>
                    <div class="row">
                        <div class="row">
                                <span class="subtitles">Hotel Description</span>
                        </div>
                        <div class="form-group row">
                                <div class="col-md-4 hotel_info">
                    
                        <label>Hotel Id</label>
                            <el-input
                            placeholder="hotelid"
                            :disabled="true"
                           
                            >
                            </el-input>
                    </div>
                      <div class="col-md-4 ">
                        <label>Hotel Name</label>
                            <el-input
                            placeholder="hotelname"
                            :disabled="true"
                            >
                            </el-input>
                    </div>
                      <div class="col-md-4">
                        <label>Hotel price</label>
                            <el-input
                            placeholder="price"
                            :disabled="true"
                            >
                            </el-input>
                    </div>
                        </div>
             
                        
                    <div class="col-md-6 hotel_address_input ">
                        <label>Hotel addres</label>
                            <el-input
                            placeholder="addres"
                            :disabled="true"
                            >
                            </el-input>
                    </div>
                       <div class="col-md-6 hotel_location_input" >
                        <label>Location</label>
                            <el-input
                            placeholder="location"
                            :disabled="true"
                            >
                            </el-input>
                    </div>
                       
                    </div>
                    <br/>
                    <div class="row hotel-desc">
                        <div class="col-md-12">
                              <label>Hotel desc</label>
                            <el-input
                        type="textarea"
                        :rows="5"
                         :disabled="true"
                        placeholder="hotel desc"
                      >
                        </el-input>

                        </div>
                    </div>
                  <br/>
                  <hr/>
                  <div class="row flight_data">
                        <div class="row">
                            <div class="row">
                                <span class="subtitles">Flight Data</span>
                            </div>
                            <br/>
                            <div class="row">
                 <div class="col-md-6 flight_number_input" >
                        <label>Flight Number</label>
                            <el-input
                            placeholder="FlightNumber"
                            :disabled="true"
                            >
                            </el-input>
                    </div>
                     <div class="col-md-6 flight_number_input">
                        <label>Flight name</label>
                            <el-input
                            placeholder="FlightName"
                            :disabled="true"
                            >
                            </el-input>
                    </div>
                            </div>
                               
                      <div class="col-md-6 aircraft_name_input">
                        <label>Flight date</label>
                            <el-input
                            placeholder="FlightDate"
                            :disabled="true"
                             suffix-icon="el-icon-date"
                            >
                            </el-input>
                    </div>
                     <div class="col-md-6">
                        <label>CompanyName</label>
                            <el-input
                            placeholder="CompanyName"
                            :disabled="true"
                            
                            >
                            </el-input>
                    </div>
                        </div>
                  </div>
                  <div class="row">
             <div class="col-md-4 aircraft_name_input">
                        <label>AirCraftName</label>
                            <el-input
                            placeholder="AirCraftName"
                            :disabled="true"
                            
                            >
                            </el-input>
                    </div>
                     <div class="col-md-4">
                        <label>TailNumber</label>
                            <el-input
                            placeholder="TailNumber"
                            :disabled="true"
                            
                            >
                            </el-input>
                    </div>
                     <div class="col-md-4 hotel_location_input">
                        <label>MAXPassagerNumber</label>
                            <el-input
                            placeholder="MAXPassagerNumber"
                            :disabled="true"
                            
                            >
                            </el-input>
                    </div>
                  </div>
                     <br/>
                  <div class="row">
              <div class="col-md-4 button" style="float:right;">
                <b-button class="left__div__button" @click="makePDF()"> Prints</b-button>
              </div>   

                  </div>
                </div>
                
            </div>
                           
    <vue-html2pdf
      :show-layout="false"
      :float-layout="true"
      :enable-download="true"
      :preview-modal="false"
      :paginate-elements-by-height="1400"
      filename="voyagerPaymentDetails"
      :pdf-quality="10"
      :manual-pagination="false"
      pdf-format="a4"
      :pdf-margin="200"
      pdf-orientation="portrait"
      pdf-content-width="1390px"
      @progress="onProgress($event)"
      ref="html2Pdf"
    ><section slot="pdf-content">
                <div class="payment_info" ref='content' id="tabalo">
                   
                    <div class="row" >
                        <div class="col-md-12 image">
                        <img  src="../../assets/voyager.png"/>
                        </div>
                    </div>
                     <div class="title row">
                        <center>
                        <h1>
                           hotel- <span class="under_title">Payment Details</span>
                        </h1>
                        </center>
                    </div>
                    <div class="row">
                        <div class="row">
                                <span class="subtitles">Hotel Description</span>
                        </div>
                        <div class="form-group row">
                                <div class="col-md-4 hotel_info">
                    
                        <label>Hotel Id</label>
                            <el-input
                            placeholder="hotelid"
                            :disabled="true"
                           
                            >
                            </el-input>
                    </div>
                      <div class="col-md-4 ">
                        <label>Hotel Name</label>
                            <el-input
                            placeholder="hotelname"
                            :disabled="true"
                            >
                            </el-input>
                    </div>
                      <div class="col-md-4">
                        <label>Hotel price</label>
                            <el-input
                            placeholder="price"
                            :disabled="true"
                            >
                            </el-input>
                    </div>
                        </div>
             
                        
                    <div class="col-md-6 hotel_address_input ">
                        <label>Hotel addres</label>
                            <el-input
                            placeholder="addres"
                            :disabled="true"
                            >
                            </el-input>
                    </div>
                       <div class="col-md-6 hotel_location_input" >
                        <label>Location</label>
                            <el-input
                            placeholder="location"
                            :disabled="true"
                            >
                            </el-input>
                    </div>
                       
                    </div>
                    <br/>
                    <div class="row hotel-desc">
                        <div class="col-md-12">
                              <label>Hotel desc</label>
                            <el-input
                        type="textarea"
                        :rows="5"
                         :disabled="true"
                        placeholder="hotel desc"
                      >
                        </el-input>

                        </div>
                    </div>
                  <br/>
                  <hr/>
                  <div class="row flight_data">
                        <div class="row">
                            <div class="row">
                                <span class="subtitles">Flight Data</span>
                            </div>
                            <br/>
                            <div class="row">
                 <div class="col-md-6 flight_number_input" >
                        <label>Flight Number</label>
                            <el-input
                            placeholder="FlightNumber"
                            :disabled="true"
                            >
                            </el-input>
                    </div>
                     <div class="col-md-6 flight_number_input">
                        <label>Flight name</label>
                            <el-input
                            placeholder="FlightName"
                            :disabled="true"
                            >
                            </el-input>
                    </div>
                            </div>
                               
                      <div class="col-md-6 aircraft_name_input">
                        <label>Flight date</label>
                            <el-input
                            placeholder="FlightDate"
                            :disabled="true"
                             suffix-icon="el-icon-date"
                            >
                            </el-input>
                    </div>
                     <div class="col-md-6">
                        <label>CompanyName</label>
                            <el-input
                            placeholder="CompanyName"
                            :disabled="true"
                            
                            >
                            </el-input>
                    </div>
                        </div>
                  </div>
                  <div class="row">
             <div class="col-md-4 aircraft_name_input">
                        <label>AirCraftName</label>
                            <el-input
                            placeholder="AirCraftName"
                            :disabled="true"
                            
                            >
                            </el-input>
                    </div>
                     <div class="col-md-4">
                        <label>TailNumber</label>
                            <el-input
                            placeholder="TailNumber"
                            :disabled="true"
                            
                            >
                            </el-input>
                    </div>
                     <div class="col-md-4 hotel_location_input">
                        <label>MAXPassagerNumber</label>
                            <el-input
                            placeholder="MAXPassagerNumber"
                            :disabled="true"
                            
                            >
                            </el-input>
                    </div>
                  </div>
                     <br/>
                     <div class="row">
                        <div class="col-md-6">

                        </div>
                        <div class="col-md-6">
                    <img src="../../assets/seal.png" style="width: 240px;height:100px"/>
                        </div>
                        
                     </div>
                  
                </div>
                 </section>
    </vue-html2pdf>
        <div>
    <FooterView class="mt-5" />
  </div>
  </div>
</template>
<script>
import HeaderView from '../../views/Header.vue'
import FooterView from '../../views/Footer.vue';
import Vue from 'vue';
import axios from 'axios';
import VueAxios from 'vue-axios';
import jsPDF from 'jspdf';
import html2canvas from 'vue-html2canvas';
import VueHtml2pdf from "vue-html2pdf";
Vue.use(VueAxios, axios)
export default {
    name: "PaymentDetails",
     components: {
    HeaderView,
    FooterView,
    VueHtml2pdf,
  },
  methods: {
     onProgress(event) {
      console.log(`Processed: ${event} / 100`);
    },
    hasGenerated() {
      alert("PDF generated successfully!");
    },
    generatePDF() {
      this.$refs.html2Pdf.generatePdf();
    },
		download() {
            // alert("download");
            // let pdfName = 'test'; 
            //  var doc = new jsPDF();

           
            //  doc.text("<div></div>", 10, 10);
            //  doc.save(pdfName + '.pdf');
             var dom = document.getElementById('tabalo');
             html2canvas(dom).then(function(canvas){
               var img = canvas.toDataURL("image/png");
               var doc = new jsPDF();
                 doc.addImage(img, 'JPEG', 20, 20);
                  doc.save('mydestination.pdf');
             })
            // const doc=new jsPDF();
            // const html= this.$refs.content.innerHTML
            // doc.fromHTML(html,15,15,{
            //     width:150
            // })
            // doc.save("VoyagerPayment.pdf")
 },
 makePDF(){
    // console.log("etes");
    // window.html2canvas=html2canvas;
    // var doc = new jsPDF("p","pt","a4");
    // doc.html(document.querySelector("#tabalo"),{
    //     callback:function(pdf){
    //         pdf.save("voyager.pdf");
    //     }
    // })
    this.$refs.html2Pdf.generatePdf();
 }
	},

   mounted() {
    this.$route.params.id;
    console.log("paymentdettailsvalla"+this.$route.params.id);
    // Vue.axios.post('https://localhost:44377/api/TicketData_OUT/' + this.$route.params.id).then((resp) => {
    //   this.list = resp.data;
      
    //   console.log('test1', resp.data)
    // });
      Vue.axios.get('https://localhost:44377/api/HotelDatas/' + this.$route.params.id).then((resp) => {
      this.list = resp.data;

      console.log('test', resp.data)
    });
  

   


  },
    data() {
    return {
      
       list: undefined,
    }
  },
}
</script>



<style scoped>
@import url("https://fonts.googleapis.com/css2?family=Open+Sans&display=swap");
@import url("https://fonts.googleapis.com/css2?family=DM+Serif+Display&display=swap");
.button{
    float:right;
    padding-left: 2%;
}
.aircraft_name_input{
    padding-left:2%
}
body{
     /* background-color: #e8eaf6; */
}
.subtitles{
    font-weight: 600;
    padding:2%;
    text-decoration: underline;
}
.image{
    padding: 4%;
}
.flight_number_input{
     padding-left:2%
}

.hotel_location_input{
      padding-right:3%
}
.hotel_address_input{
    padding-left:2%
}

.hotel-desc{
    padding-top: 5px;
    padding-left: 1%;
    padding-right:2%;
}
.hotel_info{
padding-left: 2%;
}
.under_title{
    font-size: smaller;
    font-weight: 300;
       font-family: 'Open Sans', sans-serif;
       
}
.title{
padding:10px;

    font-weight: bold;
   
       font-family: "DM Serif Display", serif;
}
.payment_info{
   
    width:60%;
    height:950px;
    background-color: white;
    margin-top: 5px;
}
.greeting {
  color: red;
  font-weight: bold;
}
.main_info{
    height: 1000px;
    display : flex;  
    justify-content : center; 
    align-content   : center;
    background-color: #e8eaf6;
    
}
</style>