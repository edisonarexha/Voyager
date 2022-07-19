<template>
  <div class="flexed" style="height: 900px">
    <side-bar :sidebar-item-color="sidebarBackground"></side-bar>
    <div class="form-max-width">
      <h4>Voyager Dashboard</h4>
      <div class="third-container">
        <div class="report-table">
          <div class="flexed justify-between">
            <h6 style="font-size: 20px">Packages</h6>
            <el-button type="primary" @click="openDialog('fromAddEvent')"
              >Add a Package</el-button
            >
          </div>
          <table class="table" style="margin-top: 15px; position: inherit; width:100%;">
            <thead>
              <th class="head-item"></th>
              <th class="head-item text-center">Package Image</th>
              <th class="head-item">Package Name</th>
              <th class="head-item">Package Price</th>
              <th class="head-item">Package Description</th>
              <th class="head-item">Created</th>
              <th class="head-item">Location</th>
              <th class="head-item">Edit/Delete</th>
            </thead>
            <tbody>
              <tr v-for="(item, index) in hotels" :key="index">
                <td class="name-width members__data">{{ index + 1 }}</td>
                <td   v-if="item.image" class="name-width member__image">
                  <img :src="require(`@/assets/${item.image}`)" />
                </td>
                <td class="name-width members__data">{{ item.hotelName }}</td>
                <td class="fields-width members__data">{{ item.hotelPrice }}</td>
                <td class="fields-width members__data" >{{ item.hotelDesc }}</td>
                <td class="fields-width members__data">{{ item.insertedDate }}</td>
                <td class="fields-width members__data">{{ item.location }}</td>
                <td style="text-align: left; vertical-align:middle;">
                  <div class="flexed" style="width: 40px; ">
                    <i
                      class="el-icon-edit pointer members__button-edit"
                      @click="openDialog('fromEditEvent', item)"
                    ></i>
                    <i
                      class="el-icon-delete pointer members__button-delete"
                      @click="deleteHotel(item)"
                    ></i>
                  </div>
                </td>
              </tr>
            </tbody>
          </table>
        </div>
      </div>
      <div>
        <el-dialog :visible.sync="dialogFormVisible">
          <el-form :model="hotel">
            <div class="flexed" style="justify-content:space-between">
              <el-form-item>
                <el-input
                  v-model="hotel.hotelName"
                  autocomplete="off"
                  placeholder="Hotel Name"
                  class="input"
                  style="width:300px"
                ></el-input>
              </el-form-item>
              <el-form-item>
                <el-input
                  v-model="hotel.location"
                  autocomplete="off"
                  placeholder="Place"
                  class="input"
                   style="width:300px"
                ></el-input>
              </el-form-item>
            </div>
            <div class="flexed" style="justify-content:space-between">
              <el-form-item>
                <el-input
                  v-model="hotel.hotelPrice"
                  autocomplete="off"
                  placeholder="Price"
                  class="input"
                   style="width:300px"
                ></el-input>
              </el-form-item>
              <el-form-item>
                <el-date-picker
                  v-model="hotel.insertedDate"
                  autocomplete="off"
                  placeholder="Date"
                   style="width:300px"
                ></el-date-picker>
              </el-form-item>
            </div>
            <el-form-item>
              <el-input
                v-model="hotel.hotelDesc"
                autocomplete="off"
                placeholder="Description"
                type="textarea"
                class="input"
                rows="5"
              ></el-input>
            </el-form-item>
            <el-form-item>
              <el-upload
                v-model="fileList"
                action="https://run.mocky.io/v3/9d059bf9-4660-45f2-925d-ce80ad6c4d15"
                list-type="picture-card"
                ref="upload"
                :on-preview="handlePictureCardPreview"
                :on-remove="handleRemove"
                :on-change="changeFileList"
                accept=".jpg, .png, .jpeg"
                :limit="1"
                :auto-upload="false"
                :file-list="fileList"
                :show-file-list="true"
              >
                <i class="el-icon-plus"></i>
              </el-upload>
            </el-form-item>
          </el-form>
          <span slot="footer" class="dialog-footer">
            <el-button type="primary" @click="save()">Add</el-button>
          </span>
        </el-dialog>
      </div>
      <!-- <div style="max-height: 400px">
        <el-form
          :model="ruleForm"
          :rules="rules"
          ref="ruleForm"
          label-width="120px"
          class="demo-ruleForm"
        >
          <div class="flexed">
            <el-form-item label="Hotel name" prop="name">
              <el-input v-model="ruleForm.name"></el-input>
            </el-form-item>
            <el-form-item label="Location" prop="name">
              <el-input v-model="ruleForm.name"></el-input>
            </el-form-item>
            <el-form-item label="Country" prop="name">
              <el-input v-model="ruleForm.name"></el-input>
            </el-form-item>
          </div>
          <div class="flexed">
            <el-form-item label="Price" prop="name">
              <el-input v-model="ruleForm.name"></el-input>
            </el-form-item>
            <el-form-item label="Package" prop="region">
              <el-select v-model="ruleForm.region" placeholder="Activity zone">
                <el-option label="Family" value="family"></el-option>
                <el-option label="Business" value="business"></el-option>
              </el-select>
            </el-form-item>
            <div>
              <el-date-picker
                v-model="value1"
                type="date"
                placeholder="Pick a day"
              >
              </el-date-picker>
            </div>
            <div>
              <el-date-picker
                v-model="value1"
                type="date"
                placeholder="Pick a day"
              >
              </el-date-picker>
            </div>
          </div>
          <div>
            <el-upload
              class="avatar-uploader"
              action="https://jsonplaceholder.typicode.com/posts/"
              :show-file-list="false"
              :on-success="handleAvatarSuccess"
              :before-upload="beforeAvatarUpload"
            >
              <img v-if="imageUrl" :src="imageUrl" class="avatar" />
              <i v-else class="el-icon-plus avatar-uploader-icon"></i>
            </el-upload>
          </div>
        </el-form>
      </div> -->
    </div>
  </div>
</template>
<script>
import SideBar from "@/components/Dashboard/SidebarPlugin/SideBar.vue";
import {
  getPackages,
  deletePackages,
  updatePackages,
  createPackages,
} from "@/sdk/packages.js";
export default {
  components: { SideBar },
  data() {
    return {
      dialogImageUrl:'',
      dialogFormVisible: false,
      status: null,
      fileList: [],
      multipleSelection: [],
      hotels: [],
      value1: "",
      imageUrl: "",
      hotel: {
        hotelId: "",
        hotelName: "",
        hotelDesc: "",
        insertedDate: "",
        image: "",
        hotelPrice: 0,
        address: "string",
        location: "",
        roomId: 0,
      },
      url: "https://localhost:44377/api/HotelDatas/SaveFile/",
      rules: {
        name: [
          {
            required: true,
            message: "Please input Activity name",
            trigger: "blur",
          },
          {
            min: 3,
            max: 5,
            message: "Length should be 3 to 5",
            trigger: "blur",
          },
        ],
        region: [
          {
            required: true,
            message: "Please select Activity zone",
            trigger: "change",
          },
        ],
        date1: [
          {
            type: "date",
            required: true,
            message: "Please pick a date",
            trigger: "change",
          },
        ],
        date2: [
          {
            type: "date",
            required: true,
            message: "Please pick a time",
            trigger: "change",
          },
        ],
        type: [
          {
            type: "array",
            required: true,
            message: "Please select at least one activity type",
            trigger: "change",
          },
        ],
        resource: [
          {
            required: true,
            message: "Please select activity resource",
            trigger: "change",
          },
        ],
        desc: [
          {
            required: true,
            message: "Please input activity form",
            trigger: "blur",
          },
        ],
      },
    };
  },
  beforeMount() {
    this.getData();
  },
  methods: {
    changeFileList(file) {
      this.dialogImageUrl = file.url;
      this.hotel.image = file.name;
      this.fileList = this.$refs.upload.uploadFiles;
      if (this.fileList.length === 2) this.fileList.splice(0, 1);
    },
    openDialog(field, item) {
      if (field === "fromEditEvent") {
        this.status = field;
        this.dialogFormVisible = true;
        this.hotel = {
          hotelId: item.hotelId,
          hotelName: item.hotelName,
          location: item.location,
          hotelPrice: item.hotelPrice,
          hotelDesc: item.hotelDesc,
          insertedDate: item.insertedDate,
          address: item.address,
          roomId: item.roomId,
          image: item.image,
        };
      } else {
        this.status = field;
        this.dialogFormVisible = true;
        this.hotel = {
          hotelName: "",
          hotelDesc: "",
          insertedDate: "",
          image: "",
          hotelPrice: 0,
          address: "string",
          location: "",
          roomId: 0,
        };
      }
    },
    async getData() {
      await getPackages().then((res) => {
        this.hotels = res.data;
      });
    },
    async deleteHotel(hotel) {
      await deletePackages(hotel).then(() => {
        this.getData();
      });
    },
    async createHotel() {
      await createPackages(this.hotel).then(() => {
        this.dialogFormVisible = false;
        this.getData();
      });
    },
    async updateHotel() {
      await updatePackages(this.hotel).then(() => {
        this.dialogFormVisible = false;
        this.getData();
      });
    },
    save() {
      if (this.status === "fromEditEvent") {
        this.updateHotel();
      } else {
        this.createHotel();
      }
    },
    submitForm(formName) {
      this.$refs[formName].validate((valid) => {
        if (valid) {
          alert("submit!");
        } else {
          console.log("error submit!!");
          return false;
        }
      });
    },
    resetForm(formName) {
      this.$refs[formName].resetFields();
    },
    handleAvatarSuccess(res, file) {
      this.imageUrl = URL.createObjectURL(file.raw);
    },
    handleRemove(file, fileList) {
      console.log(file, fileList);
    },
    handlePictureCardPreview() {
      this.dialogVisible = true;
    },
    beforeAvatarUpload(file) {
      const isJPG = file.type === "image/jpeg";
      const isLt2M = file.size / 1024 / 1024 < 2;

      if (!isJPG) {
        this.$message.error("Avatar picture must be JPG format!");
      }
      if (!isLt2M) {
        this.$message.error("Avatar picture size can not exceed 2MB!");
      }
      return isJPG && isLt2M;
    },
  },
};
</script>

<style lang="scss" scoped>
.flexed {
  display: flex;
}
.justify-between {
  justify-content: space-between;
}
.pointer {
  cursor: pointer;
}
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
  width: 80%;
  padding: 20px;
}
.header {
  padding: 20px;
}
.report-table {
  border: 1px solid #00000021;
  border-radius: 8px;
  width: 100%;
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
.input {
  width: 100%;
}

.error__style {
  text-align: center;
  font-weight: bold;
  font-size: 18px;
  font-family: "Open Sans", sans-serif;
}
.avatar-uploader .el-upload {
  border: 1px dashed #d9d9d9;
  border-radius: 6px;
  cursor: pointer;
  position: relative;
  overflow: hidden;
}
.avatar-uploader .el-upload:hover {
  border-color: #409eff;
}
.avatar-uploader-icon {
  font-size: 28px;
  color: #8c939d;
  width: 178px;
  height: 178px;
  line-height: 178px;
  text-align: center;
}
.avatar {
  width: 178px;
  height: 178px;
  display: block;
}
.table {
  margin-top: 1rem;
  font-size: 14px;
  width: 1100px;

  .check {
    padding: 10px;
    width: 30px;
  }

  .table-head {
    display: flex;
    border-bottom: 1px solid #d4d4d4;
    font-weight: bold;

    .head-item {
      flex: 1;
      padding: 10px;
      text-align: left;
      cursor: pointer;
      display: flex;
      align-items: center;

      /*.sort-icon {
        visibility: hidden;
      }

      &:hover {
        .sort-icon {
          visibility: visible;
        }
      }*/
    }
  }
}

.member__image {
  width: 250px;
}

.members__data {
  vertical-align: middle;
  font-size: 18px;
  font-family: "Open Sans", sans-serif;
}


.members__button-delete {
  color: red;
  font-size: 25px;
  margin-left: 10px;
  opacity: 0.6;
}

.members__button-edit {
  font-size: 25px;
  // margin-left:20px;
  vertical-align: middle;
  opacity: 0.6;
}
.members__button-edit:hover,
.members__button-delete:hover {
  opacity: 1;
}
</style>
