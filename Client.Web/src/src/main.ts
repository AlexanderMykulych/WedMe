import { createApp } from 'vue'
import App from './App.vue'

import { apolloProvider } from "./ApolloClient";

var app = createApp(App);
app.mount('#app')

app.use(apolloProvider)


