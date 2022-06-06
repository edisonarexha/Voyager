<!-- <template>
  <div>
      <Header></Header>
      <div class="row" style="border:1px solid black">
    test
      </div>
  </div>
</template>

<script>
import Header from "./Header.vue";
export default {
components:{Header}
}
data() {
    
      return {
        slide: 0,
        sliding: null
      }
    },
    methods: {
      onSlideStart(slide) {
        this.sliding = true
      },
      onSlideEnd(slide) {
        this.sliding = false
      },
       axios.get('https://api.com/v1/users')
            .then(function( response ){
                this.users = response.data;
            }.bind(this));
    }

}
</script>

<style>

</style> -->