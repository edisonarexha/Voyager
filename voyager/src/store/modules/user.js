const state = () => ({
    user: {
      loggedIn: false,
      data: null,
    },
  });
  
  const mutations = {
    SET_LOGGED_IN(state, value) {
      state.user.loggedIn = value;
    },
    SET_USER(state, userData) {
      state.user.data = userData;
      localStorage.setItem('userData', JSON.stringify(userData))
    },
  };
  
  const actions = {
    fetchUser({ commit }, user) {
      commit("SET_USER", user ? user : null);
      commit("SET_LOGGED_IN", user !== null);
    },
  };
  
  const getters = {
    user(state) {
      return state.user;
    },
  };
  
  export default {
    state,
    mutations,
    actions,
    getters,
  };