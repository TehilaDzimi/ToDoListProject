import axios from 'axios';

// Set the default API URL
const apiUrl = "http://localhost:5006";
axios.defaults.baseURL = apiUrl;

// Add an interceptor to log errors
axios.interceptors.response.use(
  response => response,
  error => {
    console.error('API error:', error); // Log the error to the console
    return Promise.reject(error); // Reject the promise to handle it in the calling code
  }
);

export default {
  getItems: async () => {
    const result = await axios.get('/items');    
    return result.data;
  },

  addItem: async (name) => {
    const result = await axios.post('/items', { name, isComplete: false });
    return result.data;
  },

  // setCompleted: async (id, isComplete) => {
  //   const result = await axios.put(`/items/${id}`, { isComplete });
  //   return result.data;
  // },

  deleteItem: async (id) => {
    await axios.delete(`/items/${id}`);
  },

  // הפונקציה להעדכון של ה-completion
  setItemCompleted: async (id, isComplete) => {
    const result = await axios.put(`/items/${id}`, { isComplete });
    return result.data;
  }
};
