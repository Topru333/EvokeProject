module.exports = {
    context: __dirname,
    entry: './app.js',
    output: {
        path: __dirname + '/dist',
        filename: 'bundle.js',
        publicPath: '/'
    },
    mode: 'development',
    watch: true,
    devServer: {
        historyApiFallback: true
    },
    module: {
        rules: [
            {
                test: /\.js$/,
                exclude: /(node_modules)/,
                use: {
                    loader: 'babel-loader',
                    options: {
                        presets: ["@babel/preset-env", "@babel/preset-react"]
                    }
                }
            },
            {
                test: /\.css$/,
                exclude: /(node_modules)/,
                use: {
                    loader: 'style-loader!css-loader'
                }
            }
        ]
    }
}