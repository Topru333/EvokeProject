import React from 'react';
import Table from '../Components/Table.js';

export default class Candidates extends React.Component {

    constructor(props) {
        super(props)

        this.state = { candidates: [], loading: true };

        fetch('api/Candidate')
            .then(response => response.json())
            .then(data => {
                this.setState({ candidates: data, loading: false });
            })
            .catch(response => {
                if (!response.ok) {
                    throw Error(response.statusText);
                }
            });
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : <Table people={this.state.candidates} tableid={'candidates'} />;
        return (
            <div>
                <h1 id='title'>Candidates</h1>
                {contents}
            </div>
        );
    }

}