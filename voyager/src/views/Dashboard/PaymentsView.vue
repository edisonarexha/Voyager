<template>
  <div class="rooms">
      <h4>Voyager Dashboard</h4>
    <div class="third-container">
      <div class="report-table">
     <div class="flexed">
        <div>
      <h6 style="font-size:20px">Payments</h6>
        </div>
      </div>
       <el-table
    ref="multipleTable"
    :data="tableData"
    style="width: 100%"
    @selection-change="handleSelectionChange">
    <el-table-column
      type="selection"
      width="55">
    </el-table-column>
    <el-table-column
      
      width="120">
      <template slot-scope="scope">{{ scope.row.date }}</template>
    </el-table-column>
    <el-table-column
      property="name"
      
      width="120">
    </el-table-column>
    <el-table-column
      property="address"
      
      show-overflow-tooltip>
    </el-table-column>
    <el-table-column
      property="address"
      
      show-overflow-tooltip>
    </el-table-column>
    <el-table-column
      property="address"
      
      show-overflow-tooltip>
    </el-table-column>
  </el-table>
  <div style="margin-top: 20px">
    <el-button @click="toggleSelection()">Clear selection</el-button>
  </div>
    </div>
    </div>
  </div>
</template>

<script>
export default {
data(){
  return{
    tableData: [{
          date: '2016-05-03',
          name: 'Tom',
          address: 'No. 189, Grove St, Los Angeles'
        }, {
          date: '2016-05-02',
          name: 'Tom',
          address: 'No. 189, Grove St, Los Angeles'
        }, {
          date: '2016-05-04',
          name: 'Tom',
          address: 'No. 189, Grove St, Los Angeles'
        }, {
          date: '2016-05-01',
          name: 'Tom',
          address: 'No. 189, Grove St, Los Angeles'
        }, {
          date: '2016-05-08',
          name: 'Tom',
          address: 'No. 189, Grove St, Los Angeles'
        }, {
          date: '2016-05-06',
          name: 'Tom',
          address: 'No. 189, Grove St, Los Angeles'
        }, {
          date: '2016-05-07',
          name: 'Tom',
          address: 'No. 189, Grove St, Los Angeles'
        }],
        multipleSelection: []
  }
},
 methods: {
      toggleSelection(rows) {
        if (rows) {
          rows.forEach(row => {
            this.$refs.multipleTable.toggleRowSelection(row);
          });
        } else {
          this.$refs.multipleTable.clearSelection();
        }
      },
      handleSelectionChange(val) {
        this.multipleSelection = val;
      }
    }
}
</script>

<style scoped>
.rooms{
  padding: 20px;
}
.header{
  padding: 20px;
}
.report-table {
  border: 1px solid #00000021;
  border-radius: 8px;
  width: 100%;
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
.bold{
  font-weight: bold;
  color: black;
}
</style>