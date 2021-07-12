import { ApolloClient, createHttpLink, InMemoryCache } from '@apollo/client/core';
import { ApolloProvider } from "@vue/apollo-option";
// HTTP connection to the API
const httpLink = createHttpLink({
    // You should use an absolute URL here
    uri: 'http://localhost:5001/graphql',
})

// Cache implementation
const cache = new InMemoryCache()

// Create the apollo client
export const apolloClient = new ApolloClient({
    link: httpLink,
    cache,
})

export const apolloProvider = new ApolloProvider({
    defaultClient: apolloClient,
})