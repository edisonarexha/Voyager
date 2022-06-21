<template>
  <div class="flexed" style="height: 900px">
    <side-bar :sidebar-item-color="sidebarBackground"></side-bar>
    <div class="form-max-width">
      <h4>Voyager Dashboard</h4>
      <div class="third-container">
      <div class="report-table">
        <div class="flexed">
          <h6 style="font-size: 20px">Trips</h6>
          <el-button type="primary" @click="dialogFormVisible=true">Add a Trip</el-button>
        </div>
        <el-table
          ref="multipleTable"
          :data="tableData"
          style="width: 950px"
          @selection-change="handleSelectionChange"
        >
          <el-table-column type="selection" width="55"> </el-table-column>
          <el-table-column width="120">
            <template slot-scope="scope">{{ scope.row.date }}</template>
          </el-table-column>
          <el-table-column property="name" width="120"> </el-table-column>
          <el-table-column property="address" show-overflow-tooltip>
          </el-table-column>
          <el-table-column property="address" show-overflow-tooltip>
          </el-table-column>
          <el-table-column property="address" show-overflow-tooltip>
          </el-table-column>
        </el-table>
        <div style="margin-top: 20px">
          <el-button @click="toggleSelection()">Clear selection</el-button>
        </div>
      </div>
    </div>
    <div>
      <el-dialog :visible.sync="dialogFormVisible">
        <el-form :model="form">
          <div class="flexed">
          <el-form-item :label-width="formLabelWidth">
            <el-input v-model="form.name" autocomplete="off" placeholder="Trip Name" class="input"></el-input>
          </el-form-item>
          <el-form-item :label-width="formLabelWidth">
            <el-input v-model="form.name" autocomplete="off" placeholder="Place" class="input"></el-input>
          </el-form-item>
          </div>
          <div class="flexed">
            <el-form-item :label-width="formLabelWidth">
            <el-input v-model="form.name" autocomplete="off" placeholder="Price" class="input"></el-input>
          </el-form-item>
          <el-form-item :label-width="formLabelWidth">
            <el-input v-model="form.name" autocomplete="off" placeholder="Date" class="input"></el-input>
          </el-form-item>
          </div>
          <el-form-item :label-width="formLabelWidth">
            <el-input v-model="form.name" autocomplete="off" placeholder="Description" type="textarea" class="input" rows="5"></el-input>
          </el-form-item>
          
        </el-form>
        <span slot="footer" class="dialog-footer">
          <el-button type="primary" @click="dialogFormVisible = false"
            >Add</el-button
          >
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
export default {
  components: { SideBar },
  data() {
    return {
      dialogFormVisible: false,
        form: {
          name: '',
          region: '',
          date1: '',
          date2: '',
          delivery: false,
          type: [],
          resource: '',
          desc: ''
        },
        // formLabelWidth: '120px',
      tableData: [
        {
          date: "2016-05-03",
          name: "Tom",
          address: "No. 189, Grove St, Los Angeles",
        },
        {
          date: "2016-05-02",
          name: "Tom",
          address: "No. 189, Grove St, Los Angeles",
        },
        {
          date: "2016-05-04",
          name: "Tom",
          address: "No. 189, Grove St, Los Angeles",
        },
        {
          date: "2016-05-01",
          name: "Tom",
          address: "No. 189, Grove St, Los Angeles",
        },
        {
          date: "2016-05-08",
          name: "Tom",
          address: "No. 189, Grove St, Los Angeles",
        },
        {
          date: "2016-05-06",
          name: "Tom",
          address: "No. 189, Grove St, Los Angeles",
        },
        {
          date: "2016-05-07",
          name: "Tom",
          address: "No. 189, Grove St, Los Angeles",
        },
      ],
      multipleSelection: [],
      value1: "",
      imageUrl: '',
      ruleForm: {
        name: "",
        region: "",
        date1: "",
        date2: "",
        delivery: false,
        type: [],
        resource: "",
        desc: "",
        image_url: null,
      },
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
  methods: {
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
        const isJPG = file.type === 'image/jpeg';
        const isLt2M = file.size / 1024 / 1024 < 2;

        if (!isJPG) {
          this.$message.error('Avatar picture must be JPG format!');
        }
        if (!isLt2M) {
          this.$message.error('Avatar picture size can not exceed 2MB!');
        }
        return isJPG && isLt2M;
      }
  },
};
</script>

<style scoped>
.flexed {
  display: flex;
}
.form-max-width {
  max-width: 80%;
  padding: 20px;
}
 .avatar-uploader .el-upload {
    border: 1px dashed #d9d9d9;
    border-radius: 6px;
    cursor: pointer;
    position: relative;
    overflow: hidden;
  }
  .avatar-uploader .el-upload:hover {
    border-color: #409EFF;
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
</style>
