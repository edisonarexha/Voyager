<template>
  <div class="rooms">
    <side-bar :sidebar-item-color="sidebarBackground"></side-bar>
    <div class="form-max-width">
      <h4>Voyager Dashboard</h4>
      <div class="third-container">
        <div class="report-table">
          <div class="flexed">
            <h6 style="font-size: 20px">Manage Contact Info</h6>
            <el-button type="primary" @click="dialogFormVisible = true"
              >{{this.detailsData.length ? 'Modify' : 'Add'}}</el-button
            >
          </div>
          <div>
            <el-form :model="form" class="flexed-form">
              <div>
                <el-form-item>
                  <el-input
                    v-model="this.detailsData[0].email"
                    autocomplete="off"
                    :disabled='true'
                    placeholder="Email"
                    class="input"
                  ></el-input>
                </el-form-item>
                <el-form-item>
                  <el-input
                    v-model="this.detailsData[0].phone"
                    :disabled='true'
                    autocomplete="off"
                    placeholder="Phone"
                    type="input"
                    class="input"
                  ></el-input>
                </el-form-item>
              </div>

              <div>
                <el-form-item>
                  <el-input
                    v-model="this.detailsData[0].address"
                    :disabled='true'
                    autocomplete="off"
                    placeholder="Address"
                    type="input"
                    class="input"
                  ></el-input>
                </el-form-item>
                <el-form-item>
                  <el-input
                    :disabled='true'
                    v-model="this.detailsData[0].website"
                    autocomplete="off"
                    placeholder="Website"
                    type="input"
                    class="input"
                  ></el-input>
                </el-form-item>
              </div>
            </el-form>
          </div>
        </div>
        <div class="report-table">
          <div class="flexed">
            <h6 style="font-size: 20px">Contact Messages</h6>
          </div>
          <el-table ref="multipleTable" :data="contactData" style="width: 950px">
            <el-table-column type="index"> </el-table-column>
            <el-table-column property="name" width="120"> </el-table-column>
            <el-table-column property="email" show-overflow-tooltip>
            </el-table-column>
            <el-table-column property="subject" show-overflow-tooltip>
            </el-table-column>
            <el-table-column property="message" show-overflow-tooltip>
            </el-table-column>
          </el-table>
        </div>
      </div>
      <div>
        <el-dialog :visible.sync="dialogFormVisible" @close="clearError">
           <p class="text-danger error__style"> {{error ? error : null}} </p>
          <el-form :model="form" class="flexed-form">
          <div>
             <el-form-item>
              <el-input
              v-if="!this.detailsData.length"
                v-model="details.email"
                autocomplete="off"
                placeholder="Email"
                class="input"
              ></el-input>
               <el-input
              v-else
                v-model="detailsData[0].email"
                autocomplete="off"
                placeholder="Email"
                class="input"
              ></el-input>
            </el-form-item>
            <el-form-item>
              <el-input
              v-if="!this.detailsData.length"
                v-model="details.address"
                autocomplete="off"
                placeholder="Address"
                type="input"
                class="input"
              ></el-input>
               <el-input
              v-else
                v-model="detailsData[0].address"
                autocomplete="off"
                placeholder="Address"
                type="input"
                class="input"
              ></el-input>
            </el-form-item>
          </div>
           <div>
            <el-form-item>
              <el-input
              v-if="!this.detailsData.length"
                v-model="details.phone"
                autocomplete="off"
                placeholder="Phone"
                type="input"
                class="input"
              ></el-input>
                <el-input
              v-else
                v-model="detailsData[0].phone"
                autocomplete="off"
                placeholder="Phone"
                type="input"
                class="input"
              ></el-input>
            </el-form-item>
            <el-form-item>
              <el-input
              v-if="!this.detailsData.length"
                v-model="details.website"
                autocomplete="off"
                placeholder="Website"
                type="input"
                class="input"
              ></el-input>
               <el-input
              v-else
                v-model="detailsData[0].website"
                autocomplete="off"
                placeholder="Website"
                type="input"
                class="input"
              ></el-input>
            </el-form-item>
           </div>
            
          </el-form>
          <span slot="footer" class="dialog-footer">
            <el-button type="primary" @click="addADetail()"
              >Done</el-button
            >
          </span>
        </el-dialog>
      </div>
    </div>
  </div>
</template>

<script>
import SideBar from "@/components/Dashboard/SidebarPlugin/SideBar.vue";
import {createDetails, editDetails, getContact, getDetails} from '@/sdk/contact'
export default {
  components: { SideBar },
  data() {
    return {
      error:'',
      details:{
        email:'',
        address:'',
        phone:'',
        website:''
      },
      contactData:[],
      detailsData:[],
      dialogFormVisible: false,
      form: {
        name: "",
        region: "",
        date1: "",
        date2: "",
        delivery: false,
        type: [],
        resource: "",
        desc: "",
      },
    };
  },
  mounted(){
    this.getAllContacts()
    this.getAllDetails()
  },
  methods: {
    clearError(){
      this.error = ''
    },
     successContactDetails() {
      this.$toast.success("Details have been updated succesfully", {
     position: "top-right",
  timeout: 3000,
  closeOnClick: true,
  pauseOnFocusLoss: true,
  pauseOnHover: true,
  draggable: true,
  draggablePercent: 0.6,
  showCloseButtonOnHover: false,
  hideProgressBar: true,
  closeButton: "button",
  icon: true,
  rtl: false
});
    },
       failContactDetails() {
           this.$toast.error("Server Error!!", {
     position: "top-right",
  timeout: 3000,
  closeOnClick: true,
  pauseOnFocusLoss: true,
  pauseOnHover: true,
  draggable: true,
  draggablePercent: 0.6,
  showCloseButtonOnHover: false,
  hideProgressBar: true,
  closeButton: "button",
  icon: true,
  rtl: false
});
    },
    toggleSelection(rows) {
      if (rows) {
        rows.forEach((row) => {
          this.$refs.multipleTable.toggleRowSelection(row);
        });
      } else {
        this.$refs.multipleTable.clearSelection();
      }
    },
    async getAllContacts(){
      this.contactData = await getContact()
    },
    async getAllDetails(){
      this.detailsData = await getDetails()
    },
    async addADetail(){
      if(!this.detailsData.length){
        if(!this.details.address.trim().length || !this.details.email.trim().length ||  !this.details.phone.trim().length 
      || !this.details.website.trim().length){
        this.error = 'Please fill all the fields!!'
      this.dialogFormVisible = true
      }
      else{
        this.error = ''
        await createDetails(this.details)
      this.dialogFormVisible = false
      }
      }
      else{
        if(!this.detailsData[0].email.trim().length || !this.detailsData[0].phone.trim().length
        || !this.detailsData[0].address.trim().length || !this.detailsData[0].website.trim().length
        ){
          this.error = 'Please fill all the fields!!'
          this.dialogFormVisible = true
        }
        else{
          this.error = ''
        const obj = {
          _id :this.detailsData[0]._id,
          email:this.detailsData[0].email,
          phone:this.detailsData[0].phone,
          address:this.detailsData[0].address,
          website:this.detailsData[0].website
        }
        const res = await editDetails(obj)
          this.dialogFormVisible = false
        if(res.status == 200){
          this.successContactDetails()
        }
        else{
          this.failContactDetails()
        }
      }
      }
    }

  },
};
</script>

<style scoped>
.rooms {
  /* padding: 20px; */
  display: flex;
  gap: 20px;
  height: 900px;
}
.third-container {
  padding: 20px;
}
.form-max-width {
  max-width: 80%;
  padding: 20px;
}
.header {
  padding: 20px;
}
.report-table {
  border: 1px solid #00000021;
  border-radius: 8px;
  width: 900px;
  /* height: 700px; */
  padding: 10px;
  margin: 15px;
}
.report-table span {
  font-style: normal;
  font-size: 10px;
  line-height: 24px;
  letter-spacing: 0.4px;
  color: #606061;
}
.bold {
  font-weight: bold;
  color: black;
}
.flexed {
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.flexed-form {
  display: flex;
  align-items: center;
  gap: 20px;
  justify-content: center;
  padding: 20px;
}
.input {
  width: 300px;
}

.error__style{
  text-align:center;
  font-weight:bold;
  font-size:18px;
          font-family: 'Open Sans', sans-serif;

}
</style>
