import React from 'react';


export default class Table extends React.Component {
    renderTableData() {
        return this.state.people.map((man, index) => {
            return (
                <tr key={index}>
                    <td>{index}</td>
                    <td>{man['Name']}</td>
                    <td>{man['Age']}</td>
                    <td>{man['Email']}</td>
                    <td>{man['Phone']}</td>
                </tr>
            )
        })
    }

    renderTableHeader() {
        if (this.state.people[0] == null) {
            return;
        }
        let header = Object.keys(this.state.people[0])
        let map = header.map((key, index) => {
            return <th key={index}>{key.toUpperCase()}</th>
        })
        return [<th key={-1}>{'INDEX'}</th>].concat(map);
    }


    constructor(props) {
        super(props)
        this.state = {
            people: this.props.people,
            tableid: this.props.tableid
        }
    }

    render() {
        return (
            <div>
                <table className={'table'} id={this.state.tableid}>
                    <tbody>
                        <tr>{this.renderTableHeader()}</tr>
                        {this.renderTableData()}
                    </tbody>
                </table>
            </div>
        );
    }
}