<template>
  <div class="flexed" style="height: 900px">
    <side-bar :sidebar-item-color="sidebarBackground"></side-bar>
    <div class="form-max-width">
      <h4>Voyager Dashboard</h4>
      <div class="third-container">
        <div class="report-table">
          <div class="flexed justify-between">
            <h6 style="font-size: 20px">Hotels</h6>
            <el-button type="primary" @click="openDialog('fromAddEvent')"
              >Add a Hotel</el-button
            >
          </div>
          <table class="table" style="margin-top: 0px; position: inherit">
            <thead>
              <th class="head-item">Hotel Image</th>
              <th class="head-item">Hotel Name</th>
              <th class="head-item">Hotel Price</th>
              <th class="head-item">Hotel Description</th>
              <th class="head-item">Created</th>
              <th class="head-item">Location</th>
            </thead>
            <tbody>
              <tr v-for="(item, index) in hotels" :key="index">
                <td class="name-width">
                  <img
                    :src="`https://localhost:44377/api/HotelDatas/SaveFile/${item.image}`"
                  />
                </td>
                <td class="name-width">{{ item.hotelName }}</td>
                <td class="fields-width">{{ item.hotelPrice }}</td>
                <td class="fields-width">{{ item.hotelDesc }}</td>
                <td class="fields-width">{{ item.insertedDate }}</td>
                <td class="fields-width">{{ item.location }}</td>
                <td style="text-align: left">
                  <div class="flexed" style="width: 40px">
                    <i
                      class="el-icon-edit pointer"
                      @click="openDialog('fromEditEvent', item)"
                    ></i>
                    <i
                      class="el-icon-delete pointer"
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
            <div class="flexed">
              <el-form-item :label-width="formLabelWidth">
                <el-input
                  v-model="hotel.hotelName"
                  autocomplete="off"
                  placeholder="Hotel Name"
                  class="input"
                ></el-input>
              </el-form-item>
              <el-form-item :label-width="formLabelWidth">
                <el-input
                  v-model="hotel.location"
                  autocomplete="off"
                  placeholder="Place"
                  class="input"
                ></el-input>
              </el-form-item>
            </div>
            <div class="flexed">
              <el-form-item :label-width="formLabelWidth">
                <el-input
                  v-model="hotel.hotelPrice"
                  autocomplete="off"
                  placeholder="Price"
                  class="input"
                ></el-input>
              </el-form-item>
              <el-form-item :label-width="formLabelWidth">
                <el-input
                  v-model="hotel.insertedDate"
                  autocomplete="off"
                  placeholder="Date"
                  class="input"
                ></el-input>
              </el-form-item>
            </div>
            <el-form-item :label-width="formLabelWidth">
              <el-input
                v-model="hotel.hotelDesc"
                autocomplete="off"
                placeholder="Description"
                type="textarea"
                class="input"
                rows="5"
              ></el-input>
            </el-form-item>
            <el-form-item :label-width="formLabelWidth">
              <input
                class="photo"
                type="file"
                id="image"
                placeholder="Photo "
              />
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
  getHotels,
  deleteHotel,
  updateHotel,
  createHotel,
} from "@/sdk/hotels.js";
export default {
  components: { SideBar },
  data() {
    return {
      dialogFormVisible: false,
      status: null,
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
        address: "",
        location: "",
        roomId: 0,
      },
      url: "",
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
          image: item.image
        };
      } else {
        this.status = field;
        this.dialogFormVisible = true;
        this.hotel = {
          hotelName: "",
          location: "",
          hotelPrice: "",
          hotelDesc: "",
          insertedDate: null,
        };
      }
    },
    async getData() {
      await getHotels().then((res) => {
        this.hotels = res.data;
      });
    },
    async deleteHotel(hotel) {
      await deleteHotel(hotel).then(() => {
        this.getData();
      });
    },
    async createHotel() {
      await createHotel(this.hotel).then(() => {
        this.dialogFormVisible = false;
        this.getData();
      });
    },
    async updateHotel() {
      await updateHotel(this.hotel).then(() => {
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
</style>
