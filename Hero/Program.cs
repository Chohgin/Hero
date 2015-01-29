
/*1. The	Hero	Class	must	include	the	following	Properties and	Methods: (21 Marks:	Functionality):
                a. Private Properties:	strength (int),	speed (int),	health (int)	(3	Marks:	Functionality).
                b. Public Properties:	name (string)	(1	Marks:	Functionality).
                c. The	constructor Method should	take	one	parameter,	name (string)	and	pass	its value	to	
                the	name property.	It	will	also	call	the	generateAbilities method	(2	Marks:	Functionality)
                d. A private generateAbilities Method	randomly	generates	the	ability	numbers	for	the	
                strength,	speed and	health properties. Each	ability	will	be	an	integer	between	1	and	100
                (4	Marks:	Functionality).
                e. A	public fight	Method	calls	the	hitAttempt method.	If	hitAttempt returns	true,	then	it	
                will	call	the	hitDamage method. The	damage	will	then	be	displayed in	a	message	on	the	
                Console	(3	Marks:	Functionality).f. A	private hitAttempt Method	that will	randomly	determine	if	the	Hero	hits	(this	should	
                be	20%	of	the	time) otherwise	it	will	return	false.	(3	Marks:	Functionality).
                g. A	private hitDamage Method	that	calculates	the	damage	the	Hero	causes	to	the	target	
                on	a	hit.	The	damage	will	be	calculated	by	multiplying the	Hero’s	strength	property	by	a	
                number	between	1	and	6.	The	method	will	return	this	value.	(3	Marks:	Functionality).
                h. A	public show Method	that	will	display	the	Hero’s	ability	scores	to	the	console	(2	Marks:	
                Functionality).
                2. In	your	main	method,	Implement the	Hero	class	by	creating	a	new	hero object. Have	the	hero	
                call	the	show method	to	display	his	abilities.	Then	have	the	hero	call	the	fight method.	Please	
                ensure	to	test	your	output	thoroughly. (4 Marks:	Functionality).
                3. Include	Internal	Documentation	for	your	program	(6 Marks:	Internal	Documentation):
                a. Ensure	you	include	a	program	header that	indicates: the	Author's	name,	Date	last	
                Modified,	Program	description,	Revision	History	(4 Marks:	Documentation).
                b. Ensure	your	program	uses	contextual	variable	names	that	help	make	the	program	
                human-readable	(2	Marks:	Documentation).
             */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Choose a name, Hero: ");
            string name = Console.ReadLine();
            //a hero is born
            Hero Hero1 = new Hero(name);

            Hero1.showStats();

            Hero1.fight();
            

            Console.ReadKey();

        }
    }
}
