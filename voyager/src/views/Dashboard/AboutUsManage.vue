<template>
  <div class="rooms">
    <side-bar :sidebar-item-color="sidebarBackground"></side-bar>
    <div class="form-max-width">

    <h4>Voyager Dashboard</h4>
    <div class="third-container">
      <div class="report-table">
        <div class="flexed">
          <h6 style="font-size: 20px">Manage About Us</h6>
          <el-button type="primary" @click="dialogFormVisible=true">Modify</el-button>
        </div>
        <div>
            <el-form :model="form">
          <el-form-item :label-width="formLabelWidth">
            <el-input v-model="form.name" autocomplete="off" placeholder="Title" class="input"></el-input>
          </el-form-item>
          <el-form-item :label-width="formLabelWidth">
            <el-input v-model="form.name" autocomplete="off" placeholder="Description" type="textarea" class="input" rows="5"></el-input>
          </el-form-item>
          
        </el-form>
        </div>
      
      </div>
    </div>
    <div>
      <el-dialog :visible.sync="dialogFormVisible">
        <el-form :model="form">
          <el-form-item :label-width="formLabelWidth">
            <el-input v-model="form.name" autocomplete="off" placeholder="Title" class="input"></el-input>
          </el-form-item>
          <el-form-item :label-width="formLabelWidth">
            <el-input v-model="form.name" autocomplete="off" placeholder="Description" type="textarea" class="input" rows="5"></el-input>
          </el-form-item>
          
        </el-form>
        <span slot="footer" class="dialog-footer">
          <el-button type="primary" @click="dialogFormVisible = false"
            >Done</el-button
          >
        </span>
      </el-dialog>
    </div>
    </div>
  </div>
</template>

<script>
import SideBar from '@/components/Dashboard/SidebarPlugin/SideBar.vue';
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
    };
  },
  methods: {
    toggleSelection(rows) {
      if (rows) {
        rows.forEach((row) => {
          this.$refs.multipleTable.toggleRowSelection(row);
        });
      } else {
        this.$refs.multipleTable.clearSelection();
      }
    },
    handleSelectionChange(val) {
      this.multipleSelection = val;
    },
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
.third-container{
  padding: 20px;
}
.form-max-width{
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
  height: 700px;
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
.input{
  width: 300px;
}
</style>
