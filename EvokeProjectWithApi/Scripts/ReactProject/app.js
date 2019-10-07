import React from 'react';
import ReactDOM from 'react-dom';
import Employees from './Pages/Employees.js';
import Candidates from './Pages/Candidates.js';
import { Route, Link, BrowserRouter as Router } from 'react-router-dom';


class App extends React.Component {
    render() {
        return (
            <div>
                <h1>Test app for Evoke company</h1>
            </div>
        );
    }
}

const routes = [
    {
        name: 'Home',
        path: '/',
        component: App
    },
    {
        name: 'Employees',
        path: '/Employees',
        component: Employees
    },
    {
        name: 'Candidates',
        path: '/Candidates',
        component: Candidates
    }
]

const routing = (
    <Router>
        <div>
            <ul>
                {routes.map((route, index) => (
                    <li key={index}>
                        <Link to={route.path}>
                            {route.name}
                        </Link>
                    </li>
                ))}
            </ul>
            {routes.map((route) => (
                <Route exact
                    key={route.path}
                    path={route.path}
                    component={route.component}
                />
            ))}
        </div>
    </Router>
)

ReactDOM.render(
    routing,
    document.getElementById('root')
);