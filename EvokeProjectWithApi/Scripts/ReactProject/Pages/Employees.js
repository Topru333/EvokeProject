import React from 'react';
import Table from '../Components/Table.js';

export default class Employees extends React.Component {

    constructor(props) {
        super(props)

        this.state = { employees: [], loading: true };
        
        fetch('api/Employee')
            .then(response => response.json())
            .then(data => this.setState({ employees: data, loading: false }))
            .catch(response => {
                if (!response.ok) {
                    throw Error(response.statusText);
                }
            });

    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : <Table people={this.state.employees} tableid={'employees'} />;
        return (
            <div>
                <h1 id='title'>Employees</h1>
                {contents}
            </div>
        );
    }

}