const state = () => ({
    user: {
      loggedIn: false,
      data: null,
      claims: null,
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
    SET_USER_CLAIMS(state, userClaims) {
      state.claims = userClaims;
    },
  };
  
  const actions = {
    fetchUser({ commit }, {user, claims}) {
      commit("SET_USER", user ? user : null);
      commit("SET_USER_CLAIMS", user ? claims : null);
      commit("SET_LOGGED_IN", user !== null);
    },
  };
  
  const getters = {
    user(state) {
      return state.user;
    },
    claims(state) {
      return state.claims;
    },
  };
  
  export default {
    state,
    mutations,
    actions,
    getters,
  };